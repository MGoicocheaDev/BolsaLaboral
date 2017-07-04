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
    public static class ContactoPersonaSeeder
    {

        public static void addContactoPersona(EFBolsaLaboralContext _context)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                var faker = new Faker();
                #region Email

                _context.ContactoPersona.AddOrUpdate(
                    new ContactoPersona
                    {
                        ContactoPersonaId = i,
                        Contacto = faker.Internet.ExampleEmail(faker.Name.FirstName(faker.PickRandom<Bogus.DataSets.Name.Gender>()), faker.Name.LastName(faker.PickRandom<Bogus.DataSets.Name.Gender>())),
                        TipoContacto = TipoContacto.Email,
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        PersonaId = faker.Random.Number(6, 15)
                    });
                #endregion
            }

            #region Telefono
            for(int i = 11; i <= 20; i++)
            {
                var faker = new Faker();
           
                _context.ContactoPersona.AddOrUpdate(
                    new ContactoPersona
                    {
                        ContactoPersonaId = i,
                        Contacto = faker.Phone.PhoneNumber(),
                        TipoContacto = TipoContacto.Movil,
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        PersonaId = faker.Random.Number(6, 15)
                    });

                
            }

           

            #endregion
            #region Redes Sociales
            for (int i = 21; i >= 30; i++)
            {
                var faker = new Faker();

                _context.ContactoPersona.AddOrUpdate(
                    new ContactoPersona
                    {
                        ContactoPersonaId = i,
                        Contacto = faker.Internet.Url(),
                        TipoContacto = faker.PickRandom<TipoContacto>(),
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        PersonaId = faker.Random.Number(6, 15)
                    });

            }
            #endregion



        }
    }
}
