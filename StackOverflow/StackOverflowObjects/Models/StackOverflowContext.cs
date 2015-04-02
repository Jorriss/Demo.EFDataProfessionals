using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using StackOverflowData.Models.Mapping;

namespace StackOverflowData.Models
{
    public partial class StackOverflowContext : DbContext
    {
        static StackOverflowContext()
        {
            Database.SetInitializer<StackOverflowContext>(null);
        }

        public StackOverflowContext()
            : base("Name=StackOverflowContext")
        {
        }

        public DbSet<Badge> Badges { get; set; }
        public DbSet<BadgeType> BadgeTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DateLookup> DateLookups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserBadge> UserBadges { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VoteCount> VoteCounts { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<VoteType> VoteTypes { get; set; }
        public DbSet<vw_PostAnswer> vw_PostAnswer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BadgeMap());
            modelBuilder.Configurations.Add(new BadgeTypeMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new DateLookupMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new PostTagMap());
            modelBuilder.Configurations.Add(new PostTypeMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new UserBadgeMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new VoteCountMap());
            modelBuilder.Configurations.Add(new VoteMap());
            modelBuilder.Configurations.Add(new VoteTypeMap());
            modelBuilder.Configurations.Add(new vw_PostAnswerMap());
        }
    }
}
