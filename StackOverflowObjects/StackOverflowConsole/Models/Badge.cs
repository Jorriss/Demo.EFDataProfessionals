using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BadgeTypeId { get; set; }
    }
}
