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
    public static class PersonaSeeder
    {
        public static void addPersona(EFBolsaLaboralContext _context)
        {

            for(int i = 1; i<= 10; i++)
            {
                var faker = new Faker();

                _context.Persona.AddOrUpdate(
                    new Persona
                    {
                        PersonaId = i,
                        Nombre = faker.Person.FirstName,
                        Apellido = faker.Person.LastName,
                        DomicilioId = faker.Random.Number(1,10),
                        EstadoCivil = faker.PickRandom<EstadoCivil>(),
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        FechaNacimiento = faker.Person.DateOfBirth,
                        Genero = faker.PickRandom<Genero>(),
                        Resumen = faker.Lorem.Paragraph(1),
                        TipoDocumento = faker.PickRandom<TipoDocumento>(),
                        PaisId = 103,
                        ImagenId = faker.Random.Number(2,10),
                        NumeroDocumento = faker.Random.Number(10000000,99999999).ToString(),
                        
                    });
            }
        }
    }
}
