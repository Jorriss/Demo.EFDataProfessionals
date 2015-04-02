using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StackOverflowData.Models.Mapping
{
    public class DateLookupMap : EntityTypeConfiguration<DateLookup>
    {
        public DateLookupMap()
        {
            // Primary Key
            this.HasKey(t => t.DateKey);

            // Properties
            this.Property(t => t.DateKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CharacterDate)
                .HasMaxLength(10);

            this.Property(t => t.FullYear)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.WeekDayName)
                .HasMaxLength(10);

            this.Property(t => t.MonthName)
                .HasMaxLength(12);

            this.Property(t => t.DateDefinition)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DateLookup");
            this.Property(t => t.DateKey).HasColumnName("DateKey");
            this.Property(t => t.DateFull).HasColumnName("DateFull");
            this.Property(t => t.CharacterDate).HasColumnName("CharacterDate");
            this.Property(t => t.FullYear).HasColumnName("FullYear");
            this.Property(t => t.QuarterNumber).HasColumnName("QuarterNumber");
            this.Property(t => t.WeekNumber).HasColumnName("WeekNumber");
            this.Property(t => t.WeekDayName).HasColumnName("WeekDayName");
            this.Property(t => t.MonthDay).HasColumnName("MonthDay");
            this.Property(t => t.MonthName).HasColumnName("MonthName");
            this.Property(t => t.YearDay).HasColumnName("YearDay");
            this.Property(t => t.DateDefinition).HasColumnName("DateDefinition");
            this.Property(t => t.WeekDay).HasColumnName("WeekDay");
            this.Property(t => t.MonthNumber).HasColumnName("MonthNumber");
        }
    }
}
