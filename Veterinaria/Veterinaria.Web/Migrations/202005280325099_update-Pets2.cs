namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePets2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "PetType", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Pets", "Color", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Pets", "Race", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "Race", c => c.String(maxLength: 50));
            AlterColumn("dbo.Pets", "Color", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Pets", "PetType", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
