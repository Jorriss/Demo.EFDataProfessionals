using System;
using System.Collections.Generic;

namespace StackOverflowConsole.Models
{
    public partial class vw_PostAnswer
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int PostTypeId { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public Nullable<int> OwnerUserId { get; set; }
        public int ViewCount { get; set; }
        public Nullable<int> CommentCount { get; set; }
        public Nullable<int> FavoriteCount { get; set; }
        public string Tags { get; set; }
        public Nullable<int> AnswerId { get; set; }
        public Nullable<int> AnswerCount { get; set; }
        public Nullable<System.DateTime> AnswerCreationDate { get; set; }
        public Nullable<int> AnswerOwnerUserId { get; set; }
        public Nullable<int> DaysToAnswer { get; set; }
    }
}
