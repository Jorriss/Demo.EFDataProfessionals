namespace EF_Test.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CarObject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mfg = c.String(),
                        Model = c.String(),
                        Year = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Cars");
        }
    }
}
