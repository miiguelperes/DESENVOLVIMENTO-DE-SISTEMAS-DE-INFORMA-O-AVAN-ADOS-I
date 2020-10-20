namespace Locadora.Veiculos.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInical : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoVeiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Categoria = c.String(nullable: false, maxLength: 100),
                        Situacao = c.String(nullable: false, maxLength: 50),
                        Ano = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoVeiculo");
        }
    }
}
