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
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Formacion> Formacion { get; set; }
        public virtual DbSet<TipoFormacion> TipoFormacion { get; set; }
        public virtual DbSet<AreaEstudio> AreaEstudio { get; set; }
        public virtual DbSet<EstadoFormacion> EstadoFormacion { get; set; }


    }

}