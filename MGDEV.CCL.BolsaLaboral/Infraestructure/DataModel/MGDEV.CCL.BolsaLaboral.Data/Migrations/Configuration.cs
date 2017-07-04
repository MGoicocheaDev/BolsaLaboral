namespace MGDEV.CCL.BolsaLaboral.Data.Migrations
{
    using Model;
    using Seed;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFBolsaLaboralContext>
    {
        

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFBolsaLaboralContext context)
        {
            //UbigeoSeeder.addUbigeo(context);
            //AreaLaboraSeeder.addAreaLaboral(context);
            //AreaFormacionSeeder.addAreaFormacion(context);
            //PaisSeeder.addPais(context);
            //EstadoFormacionSeeder.addEstadoFormacion(context);
            //TipoFormacionSeeder.addTipoFormacion(context);
            //DomicilioSeeder.addDomicilio(context);
            //ImagenSeeder.addImage(context);
            //PersonaSeeder.addPersona(context);
            ContactoPersonaSeeder.addContactoPersona(context);
        }
    }
}
