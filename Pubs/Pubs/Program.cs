using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new PubsContext())
            {
                var titles = from t in context.Titles
                             .Where(c => c.Title=="Life Without Fear")
                                 select new { t.Title };

                foreach (var title in titles)
                {
                    Console.WriteLine(title.Title);
                }
            }
            Console.ReadKey();
        }
    }
}
