using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImplicitConversion();
        }

        //public static void ImplicitConversion()
        //{
        //    using (var context = new EFTestContext())
        //    {
        //        var cars = context.Cars;
        //        foreach (var car in cars)
        //        {
        //            Console.WriteLine(car.Year.ToString() + " " + car.Mfg + " " + car.Model);
        //        }
        //    }
        //}

        public static void Demo1()
        {
            EFTestContext context = new EFTestContext();

            // Create new person
            Person p = new Person {FirstName = "Testy", LastName = "User"};
            context.People.Add(p);
            context.SaveChanges();

            // Retrieve all rows in Person Table
            foreach (Person dbPerson in context.People.ToList())
            {
                Console.Write("Id: {0}, ", dbPerson.Id.ToString());
                Console.Write("FirstName: {0}, ", dbPerson.FirstName.ToString());
                Console.WriteLine("LastName: {0}", dbPerson.LastName.ToString());
            }

            // Print Connection String
            Console.WriteLine("Database Connection: {0}", context.Database.Connection.ConnectionString.ToString());
            Console.ReadKey();
        }
    }
}
