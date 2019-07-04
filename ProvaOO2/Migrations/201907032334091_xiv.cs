namespace ProvaOO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xiv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conta", "nome", c => c.String());
            AddColumn("dbo.Conta", "cpf", c => c.String());
            AddColumn("dbo.Conta", "email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Conta", "email");
            DropColumn("dbo.Conta", "cpf");
            DropColumn("dbo.Conta", "nome");
        }
    }
}
