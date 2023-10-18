namespace ListaDeEsperaPacientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propriedadeObservacaoInserido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "Observacao", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacientes", "Observacao");
        }
    }
}
