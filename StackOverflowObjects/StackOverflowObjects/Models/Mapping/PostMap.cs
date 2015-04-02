using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Body)
                .IsRequired();

            this.Property(t => t.LastEditorDisplayName)
                .HasMaxLength(40);

            this.Property(t => t.Tags)
                .HasMaxLength(150);

            this.Property(t => t.Title)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Posts");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AcceptedAnswerId).HasColumnName("AcceptedAnswerId");
            this.Property(t => t.AnswerCount).HasColumnName("AnswerCount");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.ClosedDate).HasColumnName("ClosedDate");
            this.Property(t => t.CommentCount).HasColumnName("CommentCount");
            this.Property(t => t.CommunityOwnedDate).HasColumnName("CommunityOwnedDate");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.FavoriteCount).HasColumnName("FavoriteCount");
            this.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
            this.Property(t => t.LastEditDate).HasColumnName("LastEditDate");
            this.Property(t => t.LastEditorDisplayName).HasColumnName("LastEditorDisplayName");
            this.Property(t => t.LastEditorUserId).HasColumnName("LastEditorUserId");
            this.Property(t => t.OwnerUserId).HasColumnName("OwnerUserId");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.PostTypeId).HasColumnName("PostTypeId");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ViewCount).HasColumnName("ViewCount");
        }
    }
}
