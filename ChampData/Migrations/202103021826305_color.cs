namespace ChampData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class color : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Color_Id", c => c.Int());
            AlterColumn("dbo.Colors", "Red", c => c.Int(nullable: false));
            AlterColumn("dbo.Colors", "Green", c => c.Int(nullable: false));
            AlterColumn("dbo.Colors", "BLue", c => c.Int(nullable: false));
            CreateIndex("dbo.Teams", "Color_Id");
            AddForeignKey("dbo.Teams", "Color_Id", "dbo.Colors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Color_Id", "dbo.Colors");
            DropIndex("dbo.Teams", new[] { "Color_Id" });
            AlterColumn("dbo.Colors", "BLue", c => c.String(nullable: false));
            AlterColumn("dbo.Colors", "Green", c => c.String(nullable: false));
            AlterColumn("dbo.Colors", "Red", c => c.String(nullable: false));
            DropColumn("dbo.Teams", "Color_Id");
        }
    }
}
