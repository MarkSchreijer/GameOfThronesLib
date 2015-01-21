namespace GameOfThronesLib.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoTFamily : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Family",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Words = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Family");
        }
    }
}
