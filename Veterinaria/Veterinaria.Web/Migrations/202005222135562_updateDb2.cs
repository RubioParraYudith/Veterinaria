namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDb2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Consults", "History_Id", "dbo.Histories");
            DropIndex("dbo.Consults", new[] { "History_Id" });
            AddColumn("dbo.Histories", "Consult_Id", c => c.Int());
            CreateIndex("dbo.Histories", "Consult_Id");
            AddForeignKey("dbo.Histories", "Consult_Id", "dbo.Consults", "Id");
            DropColumn("dbo.Consults", "History_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Consults", "History_Id", c => c.Int());
            DropForeignKey("dbo.Histories", "Consult_Id", "dbo.Consults");
            DropIndex("dbo.Histories", new[] { "Consult_Id" });
            DropColumn("dbo.Histories", "Consult_Id");
            CreateIndex("dbo.Consults", "History_Id");
            AddForeignKey("dbo.Consults", "History_Id", "dbo.Histories", "Id");
        }
    }
}
