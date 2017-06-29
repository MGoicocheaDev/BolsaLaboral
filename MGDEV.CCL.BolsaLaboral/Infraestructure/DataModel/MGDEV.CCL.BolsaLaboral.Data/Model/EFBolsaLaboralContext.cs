namespace MGDEV.CCL.BolsaLaboral.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MGDEV.CCL.BolsaLaboral.Entities.Model;
    using System.Data.Entity.ModelConfiguration.Conventions;

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
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
    }

}