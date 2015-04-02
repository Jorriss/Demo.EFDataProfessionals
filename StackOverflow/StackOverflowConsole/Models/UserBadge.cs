using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class UserBadge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public System.DateTime Date { get; set; }
    }
}
