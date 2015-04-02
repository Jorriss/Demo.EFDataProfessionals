using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class Post
    {

        public Post()
        {
            this.PostTags = new List<PostTag>();
            this.OwnerUser = new User();
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public Nullable<int> AcceptedAnswerId { get; set; }
        public Nullable<int> AnswerCount { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public Nullable<int> CommentCount { get; set; }
        public Nullable<System.DateTime> CommunityOwnedDate { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<int> FavoriteCount { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public string LastEditorDisplayName { get; set; }
        public Nullable<int> LastEditorUserId { get; set; }
        public Nullable<int> OwnerUserId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int PostTypeId { get; set; }
        public int Score { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual User OwnerUser { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
