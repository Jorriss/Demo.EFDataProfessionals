using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class Vote
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> BountyAmount { get; set; }
        public int VoteTypeId { get; set; }
        public System.DateTime CreationDate { get; set; }
    }
}
