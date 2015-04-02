using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class vw_PostAnswerMap : EntityTypeConfiguration<vw_PostAnswer>
    {
        public vw_PostAnswerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.QuestionId, t.PostTypeId, t.CreationDate, t.LastActivityDate, t.ViewCount });

            // Properties
            this.Property(t => t.QuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(250);

            this.Property(t => t.PostTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ViewCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tags)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("vw_PostAnswer");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.PostTypeId).HasColumnName("PostTypeId");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.LastActivityDate).HasColumnName("LastActivityDate");
            this.Property(t => t.LastEditDate).HasColumnName("LastEditDate");
            this.Property(t => t.OwnerUserId).HasColumnName("OwnerUserId");
            this.Property(t => t.ViewCount).HasColumnName("ViewCount");
            this.Property(t => t.CommentCount).HasColumnName("CommentCount");
            this.Property(t => t.FavoriteCount).HasColumnName("FavoriteCount");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.AnswerId).HasColumnName("AnswerId");
            this.Property(t => t.AnswerCount).HasColumnName("AnswerCount");
            this.Property(t => t.AnswerCreationDate).HasColumnName("AnswerCreationDate");
            this.Property(t => t.AnswerOwnerUserId).HasColumnName("AnswerOwnerUserId");
            this.Property(t => t.DaysToAnswer).HasColumnName("DaysToAnswer");
        }
    }
}
