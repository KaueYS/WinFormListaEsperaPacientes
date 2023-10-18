namespace ListaDeEsperaPacientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeiraMigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Telefone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        DataCadastro = c.DateTime(nullable: false),
                        Finalizado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
