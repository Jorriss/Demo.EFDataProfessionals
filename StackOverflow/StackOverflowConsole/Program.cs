using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackOverflowConsole.Models;


namespace StackOverflowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo readKey;
            do
            {
                Console.WriteLine("Enter to run demo:");
                Console.WriteLine("1: Top 100 users");
                Console.WriteLine("2: One User");
                Console.WriteLine("3: One User All Posts");
                Console.WriteLine("4: Like Query");
                Console.WriteLine("5: Like Query FullText");
                Console.WriteLine("x: Exit");
                Console.WriteLine();

                readKey = Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine();

                var watch = new Stopwatch();
                watch.Start();

                switch (readKey.KeyChar)
                {
                    case '1':
                        Users100();
                        break;
                    case '2':
                        OneUser();
                        break;
                    case '3':
                        UserPosts();
                        break;
                    case '4':
                        LikeQuery();
                        break;
                    case '5':
                        LikeQueryFullText();
                        break;
                }
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds + " miliseconds.");
                Console.WriteLine();

            } while (readKey.KeyChar != 'x');

            Console.WriteLine();
        }

        private static void Users100()
        {
            using (var context = new StackOverflowContext())
            {

                var users = context.Users
                                   .Select(c => c.Id)
                                   .Take(100);

                foreach (var id in users)
                {
                    Console.WriteLine(id);
                }
            }
        }

        static void OneUser()
        {
            using (var context = new StackOverflowContext())
            {

                var users = context.Users
                    .Where(c => c.DisplayName == "Jorriss")
                    .Select(c => c.DisplayName);

                foreach (var user in users)
                {
                    Console.WriteLine(user);
                }
            }
        }
        static void UserPosts()
        {
            using (var context = new StackOverflowContext())
            {

                var p2 = context.Posts
                                .Include(i => i.OwnerUser)
                                .Include(i => i.Comments)
                                .Include(i => i.PostTags)
                                .Where(p => p.Id == 308);

                foreach (var p in p2)
                {
                    Console.WriteLine(p.Title);
                }
            }
        }

        static void LikeQuery()
        {
            using (var context = new StackOverflowContext())
            {
                var posts = context.Posts
                                   .Where(p => p.Title.Contains("COBOL"));

                foreach (var p in posts)
                {
                    Console.WriteLine(p.Title);
                }
            }
        }
        static void LikeQueryFullText()
        {
            using (var context = new StackOverflowContext())
            {
                var posts = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<Post>(
                    "SELECT * FROM Posts WHERE FREETEXT(Title,{0})", "COBOL"
                       ).AsQueryable();

                foreach (var p in posts)
                {
                    Console.WriteLine(p.Title);
                }
            }
        }
    }
}
