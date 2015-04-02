using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class VoteCount
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int VoteTypeId { get; set; }
        public int VoteCount1 { get; set; }
    }
}
