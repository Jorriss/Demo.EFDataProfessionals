using System;
using System.Collections.Generic;

namespace StackOverflowData.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public Nullable<int> Age { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string DisplayName { get; set; }
        public int DownVotes { get; set; }
        public string EmailHash { get; set; }
        public System.DateTime LastAccessDate { get; set; }
        public string Location { get; set; }
        public int Reputation { get; set; }
        public int UpVotes { get; set; }
        public int Views { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
