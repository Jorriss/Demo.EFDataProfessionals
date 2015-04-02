using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class PostTypeMap : EntityTypeConfiguration<PostType>
    {
        public PostTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PostTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
