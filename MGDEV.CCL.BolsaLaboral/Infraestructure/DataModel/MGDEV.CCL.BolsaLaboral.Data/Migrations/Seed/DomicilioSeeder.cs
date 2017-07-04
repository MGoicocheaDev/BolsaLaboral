using Bogus;
using MGDEV.CCL.BolsaLaboral.Data.Model;
using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using MGDEV.CCL.BolsaLaboral.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Data.Migrations.Seed
{
    public static class DomicilioSeeder
    {
        public static void addDomicilio(EFBolsaLaboralContext _context)
        {
            for(int i = 1; i <= 10; i++)
            {
                var faker = new Faker();
                _context.Domicilio.AddOrUpdate(
                    new Domicilio
                    {
                        DomicilioId = i,
                        Direccion = faker.Address.FullAddress(),
                        TipoDireccion = faker.PickRandom<TipoDireccion>(),
                        Seccion = faker.Address.BuildingNumber(),
                        Urbanizacion = faker.Address.StreetName(),
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        CodigoUbigeo = "150131"
                    });
            }
        }
    }
}
