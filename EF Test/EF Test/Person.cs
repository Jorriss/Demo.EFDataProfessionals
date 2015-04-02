using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;

namespace EFTest
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
    }

    public class EFTestContext : DbContext
    {
        public DbSet<EFTest.Person> People { get; set; }
    }
}
