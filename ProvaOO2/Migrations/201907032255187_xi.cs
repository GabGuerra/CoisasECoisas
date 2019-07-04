namespace ProvaOO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "openbox", c => c.Boolean(nullable: false));
            DropColumn("dbo.Estoque", "openbox");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "openbox", c => c.Boolean(nullable: false));
            DropColumn("dbo.Produto", "openbox");
        }
    }
}
