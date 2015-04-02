using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs
{
    [Table("Titles")]
    public class TitleName
    {
        [Key]
        public string Title_ID { get; set; }
		[Column("Title", TypeName="varchar")]
		public string Title { get; set; }
        public string Type { get; set; }
        public string Pub_ID { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YTD_Sales { get; set; }
        public string Notes { get; set; }
        public DateTime? PubDate { get; set; }
    }

    public class PubsContext : DbContext
    {

        static PubsContext()
        {
            Database.SetInitializer<PubsContext>(null);
        }

        public PubsContext()
            : base()
        {

        }
        public DbSet<Pubs.TitleName> Titles { get; set; }
    }

}
