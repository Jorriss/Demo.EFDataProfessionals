using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.EmailHash)
                .HasMaxLength(40);

            this.Property(t => t.Location)
                .HasMaxLength(100);

            this.Property(t => t.WebsiteUrl)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AboutMe).HasColumnName("AboutMe");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.DownVotes).HasColumnName("DownVotes");
            this.Property(t => t.EmailHash).HasColumnName("EmailHash");
            this.Property(t => t.LastAccessDate).HasColumnName("LastAccessDate");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Reputation).HasColumnName("Reputation");
            this.Property(t => t.UpVotes).HasColumnName("UpVotes");
            this.Property(t => t.Views).HasColumnName("Views");
            this.Property(t => t.WebsiteUrl).HasColumnName("WebsiteUrl");
        }
    }
}
