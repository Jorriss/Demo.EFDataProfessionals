using System;
using System.Collections.Generic;

namespace StackOverflowData.Models
{
    public partial class DateLookup
    {
        public int DateKey { get; set; }
        public Nullable<System.DateTime> DateFull { get; set; }
        public string CharacterDate { get; set; }
        public string FullYear { get; set; }
        public Nullable<byte> QuarterNumber { get; set; }
        public Nullable<byte> WeekNumber { get; set; }
        public string WeekDayName { get; set; }
        public Nullable<byte> MonthDay { get; set; }
        public string MonthName { get; set; }
        public Nullable<short> YearDay { get; set; }
        public string DateDefinition { get; set; }
        public Nullable<byte> WeekDay { get; set; }
        public Nullable<byte> MonthNumber { get; set; }
    }
}
