using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(700);

            // Table & Column Mappings
            this.ToTable("Comments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.PostId).HasColumnName("PostId");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
