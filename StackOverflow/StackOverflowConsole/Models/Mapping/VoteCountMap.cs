using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowConsole.Models.Mapping
{
    public class VoteCountMap : EntityTypeConfiguration<VoteCount>
    {
        public VoteCountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("VoteCounts");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PostId).HasColumnName("PostId");
            this.Property(t => t.VoteTypeId).HasColumnName("VoteTypeId");
            this.Property(t => t.VoteCount1).HasColumnName("VoteCount");
        }
    }
}
