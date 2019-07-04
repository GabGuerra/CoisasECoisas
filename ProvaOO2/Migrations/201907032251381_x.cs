namespace ProvaOO2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        clienteId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cpf = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.clienteId);
            
            CreateTable(
                "dbo.Conta",
                c => new
                    {
                        contaId = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        senha = c.String(),
                    })
                .PrimaryKey(t => t.contaId);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        estoqueId = c.Int(nullable: false, identity: true),
                        openbox = c.Boolean(nullable: false),
                        quantidade = c.Int(nullable: false),
                        produtoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.estoqueId)
                .ForeignKey("dbo.Produto", t => t.produtoId, cascadeDelete: true)
                .Index(t => t.produtoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        produtoId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        descricao = c.String(),
                    })
                .PrimaryKey(t => t.produtoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "produtoId", "dbo.Produto");
            DropIndex("dbo.Estoque", new[] { "produtoId" });
            DropTable("dbo.Produto");
            DropTable("dbo.Estoque");
            DropTable("dbo.Conta");
            DropTable("dbo.Cliente");
        }
    }
}
