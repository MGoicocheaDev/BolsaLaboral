namespace MGDEV.CCL.BolsaLaboral.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPersona : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        PersonaId = c.Long(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Correo = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Contraseña = c.String(),
                        Token = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persona");
        }
    }
}
