namespace MGDEV.CCL.BolsaLaboral.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MGDEV.CCL.BolsaLaboral.Entities.Model;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EFBolsaLaboralContext : DbContext
    {
        // Your context has been configured to use a 'EFBolsaLaboralContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MGDEV.CCL.BolsaLaboral.Data.Model.EFBolsaLaboralContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EFBolsaLaboralContext' 
        // connection string in the application configuration file.
        public EFBolsaLaboralContext()
            : base("name=EFBolsaLaboralContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Persona

            modelBuilder.Entity<Persona>()
                        .Property(x => x.Nombre)
                        .HasMaxLength(300)
                        .IsRequired();

            modelBuilder.Entity<Persona>()
                        .Property(x => x.Apellido)
                        .HasMaxLength(300)
                        .IsRequired();

            modelBuilder.Entity<Persona>()
                .Property(x => x.NumeroDocumento)
                .HasMaxLength(20)
                .IsOptional();

            modelBuilder.Entity<Persona>()
                .Property(x => x.Resumen)
                .HasMaxLength(300)
                .IsRequired();

            modelBuilder.Entity<Persona>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();

            #endregion

            #region Ubigeo

            modelBuilder.Entity<Ubigeo>()
                .HasKey(x => x.CodigoUbigeo)
                .Property(x => x.CodigoUbigeo)
                .HasMaxLength(6)
                .HasColumnType("char")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Departamento)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Provincia)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Ubigeo>()
                .Property(x => x.Distrito)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Pais

            modelBuilder.Entity<Pais>()
                .Property(x => x.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Domicilio

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.TipoDireccion)
                .IsRequired();

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Direccion)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Seccion)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Domicilio>()
                .Property(x => x.Urbanizacion)
                .IsOptional()
                .HasMaxLength(150);

            #endregion

            #region Formacion

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Titulo)
                .HasMaxLength(250)
                .IsRequired();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Institucion)
                .HasMaxLength(300)
                .IsRequired();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.MesFin)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.AnioFin)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.MesInicio)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.AnioInicio)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .Property(x => x.Promedio)
                .IsOptional();

            modelBuilder.Entity<Formacion>()
                .HasRequired(x => x.Pais)
                .WithMany()
                .WillCascadeOnDelete(false);
            #endregion

            #region Experiencia Laboral
            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.Empresa)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.Puesto)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.FechaInicio)
                .IsRequired();

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.FechaFin)
                .IsOptional();

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.DescripcionResponsabilidad)
                .IsRequired()
                .HasMaxLength(400);

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.FechaCreacion)
                .IsRequired();

            modelBuilder.Entity<ExperienciaLaboral>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();

            modelBuilder.Entity<ExperienciaLaboral>()
                .HasRequired(x => x.Pais)
                .WithMany()
                .WillCascadeOnDelete(false);
            #endregion

            #region ContactoPersona
            modelBuilder.Entity<ContactoPersona>()
                .Property(x => x.Contacto)
                .HasMaxLength(400)
                .IsRequired();

            modelBuilder.Entity<ContactoPersona>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();
            #endregion

            #region Imagen

            modelBuilder.Entity<Imagen>()
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Imagen>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();

            modelBuilder.Entity<Imagen>()
                .Property(x => x.Archivo)
                .HasColumnType("image")
                .IsRequired();
            #endregion

            #region ContactoEmpresa
            modelBuilder.Entity<ContactoEmpresa>()
                .Property(x => x.Contacto)
                .HasMaxLength(400)
                .IsRequired();

            modelBuilder.Entity<ContactoEmpresa>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();
            #endregion

            #region Empresa
            modelBuilder.Entity<Empresa>()
                .Property(x => x.RUC)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Empresa>()
                .Property(x => x.RazonSocial)
                .HasMaxLength(300)
                .IsRequired();

            modelBuilder.Entity<Empresa>()
                .Property(x => x.Descripcion)
                .HasMaxLength(600)
                .IsRequired();

            modelBuilder.Entity<Empresa>()
                .Property(x => x.FechaActualizacion)
                .IsOptional();
            #endregion

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Formacion> Formacion { get; set; }
        public virtual DbSet<TipoFormacion> TipoFormacion { get; set; }
        public virtual DbSet<EstadoFormacion> EstadoFormacion { get; set; }
        public virtual DbSet<AreaFormacion> AreaFormacion { get; set; }
        public virtual DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public virtual DbSet<AreaLaboral> AreaLaboral { get; set; }
        public virtual DbSet<ContactoPersona> ContactoPersona { get; set; }
        public virtual DbSet<Imagen> Imagen { get; set; }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<ContactoEmpresa> ContactoEmpresa { get; set; }


    }

}