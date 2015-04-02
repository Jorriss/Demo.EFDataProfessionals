using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Timers;

namespace AdventureWorksEF
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo readKey;
            do
            {
                Console.WriteLine("Enter to run demo:");
                Console.WriteLine("1: ADO.Net");
                Console.WriteLine("2: N + 1");
                Console.WriteLine("3: N + 1 Fix");
                Console.WriteLine("4: Index Killer");
                Console.WriteLine("5: Index Fix");
                Console.WriteLine("6: Searching");
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
                        ADONetTest.Select();
                        break;
                    case '2':
                        NPlusOne();
                        break;
                    case '3':
                        NPlusOneFix();
                        break;
                    case '4':
                        IndexKiller();
                        break;
                    case '5':
                        IndexFixed();
                        break;
                    case '6':
                        Searching();
                        break;
                }
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds + " miliseconds.");
                Console.WriteLine();

            } while (readKey.KeyChar != 'x');

            Console.WriteLine();
        }

        static void ADONetSelect()
        {
            
        }

        static void NPlusOne()
        {
            using (var context = new AdvWorks())
            {
                foreach (var store in context.Stores)
                {
                    Console.WriteLine(store.Name);
                    foreach (var cust in store.Customers)
                    {
                        Console.WriteLine("  " + cust.AccountNumber);
                    }
                }

            }
        }

        static void NPlusOneFix()
        {
            using (var context = new AdvWorks())
            {
                var stores = context.Stores.Include(c => c.Customers);
                foreach (var store in stores)
                {
                    Console.WriteLine(store.Name);
                    foreach (var cust in store.Customers)
                    {
                        Console.WriteLine("  " + cust.AccountNumber);
                    }
                }

            }
        }

        static void IndexKiller()
        {
            using (var context = new AdvWorks())
            {
                var store = (from s in context.Stores
                             where s.Name == "World of Bikes"
                             select s).FirstOrDefault();

                Console.WriteLine("{0}: {1}", store.BusinessEntityID, store.Name);
            }
        }

        static void IndexFixed()
        {
            using (var context = new AdvWorks())
            {
                var store = (from s in context.Stores
                             where s.Name == "World of Bikes"
                             select new {s.BusinessEntityID ,s.Name}).FirstOrDefault();

                Console.WriteLine("{0}: {1}", store.BusinessEntityID, store.Name);
            }
        }

        static void Searching()
        {
            using (var context = new AdvWorks())
            {
                var store = context.Stores
                    .Where(c => c.Name.Contains("Bikes"));
                foreach (var p in store)
                {
                    Console.WriteLine(p.Name);
                }
            }
        }

    }
}
