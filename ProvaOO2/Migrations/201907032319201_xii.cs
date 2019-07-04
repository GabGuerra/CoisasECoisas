namespace ProvaOO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xii : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conta", "login", c => c.String(nullable: false));
            AlterColumn("dbo.Conta", "senha", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Conta", "senha", c => c.String());
            AlterColumn("dbo.Conta", "login", c => c.String());
        }
    }
}
