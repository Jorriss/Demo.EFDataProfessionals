using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowConsole.Models.Mapping
{
    public class PostTagMap : EntityTypeConfiguration<PostTag>
    {
        public PostTagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PostId, t.Tag });

            // Properties
            this.Property(t => t.PostId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PostTags");
            this.Property(t => t.PostId).HasColumnName("PostId");
            this.Property(t => t.Tag).HasColumnName("Tag");

            // Relationships
            this.HasRequired(t => t.Post)
                .WithMany(t => t.PostTags)
                .HasForeignKey(d => d.PostId);
        }
    }
}
