using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class PostTag
    {
        public int PostId { get; set; }
        public string Tag { get; set; }
        public virtual Post Post { get; set; }
    }
}
