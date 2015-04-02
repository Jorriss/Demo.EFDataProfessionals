using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowConsole.Models.Mapping
{
    public class BadgeTypeMap : EntityTypeConfiguration<BadgeType>
    {
        public BadgeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BadgeTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
