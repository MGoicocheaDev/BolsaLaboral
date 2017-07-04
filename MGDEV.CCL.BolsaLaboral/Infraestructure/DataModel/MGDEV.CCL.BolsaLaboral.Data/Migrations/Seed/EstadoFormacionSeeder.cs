using MGDEV.CCL.BolsaLaboral.Data.Model;
using MGDEV.CCL.BolsaLaboral.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Data.Migrations.Seed
{
    public static class EstadoFormacionSeeder
    {
        public static void addEstadoFormacion(EFBolsaLaboralContext _context)
        {
            _context.EstadoFormacion.AddOrUpdate(
                new EstadoFormacion { EstadoFormacionId = 1, Nombre = "En Curso"},
                new EstadoFormacion { EstadoFormacionId = 2, Nombre = "Egresado" },
                new EstadoFormacion { EstadoFormacionId = 3, Nombre = "Titulado" },
                new EstadoFormacion { EstadoFormacionId = 4, Nombre = "Trunco" }

                );
        }
    }
}
