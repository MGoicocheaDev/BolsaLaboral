namespace MGDEV.CCL.BolsaLaboral.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaFormacion",
                c => new
                    {
                        AreaFormacionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AreaFormacionId);
            
            CreateTable(
                "dbo.AreaLaboral",
                c => new
                    {
                        AreaLaboralId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AreaLaboralId);
            
            CreateTable(
                "dbo.ContactoEmpresa",
                c => new
                    {
                        ContactoEmpresaId = c.Long(nullable: false, identity: true),
                        EmpresaId = c.Long(nullable: false),
                        TipoContacto = c.Int(nullable: false),
                        Contacto = c.String(nullable: false, maxLength: 400),
                        Visible = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.ContactoEmpresaId)
                .ForeignKey("dbo.Empresa", t => t.EmpresaId, cascadeDelete: true)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaId = c.Long(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false, maxLength: 300),
                        RUC = c.String(nullable: false, maxLength: 15),
                        PaisId = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 600),
                        DomicilioId = c.Long(nullable: false),
                        ActividadEmpresa = c.String(),
                        ImagenId = c.Long(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.EmpresaId)
                .ForeignKey("dbo.Domicilio", t => t.DomicilioId, cascadeDelete: true)
                .ForeignKey("dbo.Imagen", t => t.ImagenId, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId)
                .Index(t => t.DomicilioId)
                .Index(t => t.ImagenId);
            
            CreateTable(
                "dbo.Domicilio",
                c => new
                    {
                        DomicilioId = c.Long(nullable: false, identity: true),
                        TipoDireccion = c.Int(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 300),
                        Seccion = c.String(nullable: false, maxLength: 100),
                        Urbanizacion = c.String(maxLength: 150),
                        CodigoUbigeo = c.String(maxLength: 6, fixedLength: true, unicode: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DomicilioId)
                .ForeignKey("dbo.Ubigeo", t => t.CodigoUbigeo)
                .Index(t => t.CodigoUbigeo);
            
            CreateTable(
                "dbo.Ubigeo",
                c => new
                    {
                        CodigoUbigeo = c.String(nullable: false, maxLength: 6, fixedLength: true, unicode: false),
                        Departamento = c.String(nullable: false, maxLength: 100),
                        Provincia = c.String(nullable: false, maxLength: 100),
                        Distrito = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CodigoUbigeo);
            
            CreateTable(
                "dbo.Imagen",
                c => new
                    {
                        ImagenId = c.Long(nullable: false, identity: true),
                        TipoImagen = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 150),
                        Archivo = c.Binary(nullable: false, storeType: "image"),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.ImagenId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        PaisId = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(nullable: false, maxLength: 100),
                        TwoLetterISO = c.String(nullable: false, maxLength: 5),
                        ISOCurrencySymbol = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.PaisId);
            
            CreateTable(
                "dbo.ContactoPersona",
                c => new
                    {
                        ContactoPersonaId = c.Long(nullable: false, identity: true),
                        PersonaId = c.Long(nullable: false),
                        TipoContacto = c.Int(nullable: false),
                        Contacto = c.String(nullable: false, maxLength: 400),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.ContactoPersonaId)
                .ForeignKey("dbo.Persona", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        PersonaId = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 300),
                        Apellido = c.String(nullable: false, maxLength: 300),
                        FechaNacimiento = c.DateTime(nullable: false),
                        TipoDocumento = c.Int(nullable: false),
                        NumeroDocumento = c.String(maxLength: 20),
                        EstadoCivil = c.Int(nullable: false),
                        Genero = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                        DomicilioId = c.Long(nullable: false),
                        Resumen = c.String(nullable: false, maxLength: 300),
                        ImagenId = c.Long(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("dbo.Domicilio", t => t.DomicilioId, cascadeDelete: true)
                .ForeignKey("dbo.Imagen", t => t.ImagenId, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId)
                .Index(t => t.DomicilioId)
                .Index(t => t.ImagenId);
            
            CreateTable(
                "dbo.Formacion",
                c => new
                    {
                        FormacionId = c.Long(nullable: false, identity: true),
                        PersonaId = c.Long(nullable: false),
                        TipoFormacionId = c.Byte(nullable: false),
                        EstadoFormacionId = c.Byte(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 250),
                        AreaFormacionId = c.Int(nullable: false),
                        Institucion = c.String(nullable: false, maxLength: 300),
                        MesInicio = c.Byte(),
                        AnioInicio = c.Byte(),
                        MesFin = c.Byte(),
                        AnioFin = c.Byte(),
                        Actual = c.Boolean(nullable: false),
                        Promedio = c.Decimal(precision: 18, scale: 2),
                        PaisId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.FormacionId)
                .ForeignKey("dbo.AreaFormacion", t => t.AreaFormacionId, cascadeDelete: true)
                .ForeignKey("dbo.EstadoFormacion", t => t.EstadoFormacionId, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisId)
                .ForeignKey("dbo.Persona", t => t.PersonaId, cascadeDelete: true)
                .ForeignKey("dbo.TipoFormacion", t => t.TipoFormacionId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.TipoFormacionId)
                .Index(t => t.EstadoFormacionId)
                .Index(t => t.AreaFormacionId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.EstadoFormacion",
                c => new
                    {
                        EstadoFormacionId = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoFormacionId);
            
            CreateTable(
                "dbo.TipoFormacion",
                c => new
                    {
                        TipoFormacionId = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoFormacionId);
            
            CreateTable(
                "dbo.ExperienciaLaboral",
                c => new
                    {
                        ExperienciaLaboralId = c.Long(nullable: false, identity: true),
                        PersonaId = c.Long(nullable: false),
                        Empresa = c.String(nullable: false, maxLength: 300),
                        ActividadEmpresa = c.String(),
                        Puesto = c.String(nullable: false, maxLength: 300),
                        NivelExperiencia = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(),
                        Presente = c.Boolean(nullable: false),
                        AreaLaboralId = c.Int(nullable: false),
                        DescripcionResponsabilidad = c.String(nullable: false, maxLength: 400),
                        PersonasACargo = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.ExperienciaLaboralId)
                .ForeignKey("dbo.AreaLaboral", t => t.AreaLaboralId, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisId)
                .ForeignKey("dbo.Persona", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.PaisId)
                .Index(t => t.AreaLaboralId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persona", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Persona", "ImagenId", "dbo.Imagen");
            DropForeignKey("dbo.ExperienciaLaboral", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.ExperienciaLaboral", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.ExperienciaLaboral", "AreaLaboralId", "dbo.AreaLaboral");
            DropForeignKey("dbo.Formacion", "TipoFormacionId", "dbo.TipoFormacion");
            DropForeignKey("dbo.Formacion", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.Formacion", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Formacion", "EstadoFormacionId", "dbo.EstadoFormacion");
            DropForeignKey("dbo.Formacion", "AreaFormacionId", "dbo.AreaFormacion");
            DropForeignKey("dbo.Persona", "DomicilioId", "dbo.Domicilio");
            DropForeignKey("dbo.ContactoPersona", "PersonaId", "dbo.Persona");
            DropForeignKey("dbo.Empresa", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Empresa", "ImagenId", "dbo.Imagen");
            DropForeignKey("dbo.Empresa", "DomicilioId", "dbo.Domicilio");
            DropForeignKey("dbo.Domicilio", "CodigoUbigeo", "dbo.Ubigeo");
            DropForeignKey("dbo.ContactoEmpresa", "EmpresaId", "dbo.Empresa");
            DropIndex("dbo.ExperienciaLaboral", new[] { "AreaLaboralId" });
            DropIndex("dbo.ExperienciaLaboral", new[] { "PaisId" });
            DropIndex("dbo.ExperienciaLaboral", new[] { "PersonaId" });
            DropIndex("dbo.Formacion", new[] { "PaisId" });
            DropIndex("dbo.Formacion", new[] { "AreaFormacionId" });
            DropIndex("dbo.Formacion", new[] { "EstadoFormacionId" });
            DropIndex("dbo.Formacion", new[] { "TipoFormacionId" });
            DropIndex("dbo.Formacion", new[] { "PersonaId" });
            DropIndex("dbo.Persona", new[] { "ImagenId" });
            DropIndex("dbo.Persona", new[] { "DomicilioId" });
            DropIndex("dbo.Persona", new[] { "PaisId" });
            DropIndex("dbo.ContactoPersona", new[] { "PersonaId" });
            DropIndex("dbo.Domicilio", new[] { "CodigoUbigeo" });
            DropIndex("dbo.Empresa", new[] { "ImagenId" });
            DropIndex("dbo.Empresa", new[] { "DomicilioId" });
            DropIndex("dbo.Empresa", new[] { "PaisId" });
            DropIndex("dbo.ContactoEmpresa", new[] { "EmpresaId" });
            DropTable("dbo.ExperienciaLaboral");
            DropTable("dbo.TipoFormacion");
            DropTable("dbo.EstadoFormacion");
            DropTable("dbo.Formacion");
            DropTable("dbo.Persona");
            DropTable("dbo.ContactoPersona");
            DropTable("dbo.Pais");
            DropTable("dbo.Imagen");
            DropTable("dbo.Ubigeo");
            DropTable("dbo.Domicilio");
            DropTable("dbo.Empresa");
            DropTable("dbo.ContactoEmpresa");
            DropTable("dbo.AreaLaboral");
            DropTable("dbo.AreaFormacion");
        }
    }
}
