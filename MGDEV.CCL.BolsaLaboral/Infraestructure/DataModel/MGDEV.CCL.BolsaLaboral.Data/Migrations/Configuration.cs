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
        private UbigeoSeeder ubigeoSeeder;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFBolsaLaboralContext context)
        {
            ubigeoSeeder = new UbigeoSeeder(context);
            ubigeoSeeder.addUbigeo();
        }
    }
}
