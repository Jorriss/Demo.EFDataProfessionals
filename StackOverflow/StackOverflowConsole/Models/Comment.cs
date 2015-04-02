using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public System.DateTime CreationDate { get; set; }
        public int PostId { get; set; }
        public Nullable<int> Score { get; set; }
        public string Text { get; set; }
        public Nullable<int> UserId { get; set; }

        public virtual Post Post { get; set; }
    }
}
