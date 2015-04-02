using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowConsole.Models.Mapping
{
    public class VoteMap : EntityTypeConfiguration<Vote>
    {
        public VoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Votes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PostId).HasColumnName("PostId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.BountyAmount).HasColumnName("BountyAmount");
            this.Property(t => t.VoteTypeId).HasColumnName("VoteTypeId");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
        }
    }
}
