using System;
using System.Collections.Generic;

namespace StackOverflowData.Models
{
    public partial class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BadgeTypeId { get; set; }
    }
}
