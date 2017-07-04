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
    public static class TipoFormacionSeeder
    {
        public static void addTipoFormacion(EFBolsaLaboralContext _context)
        {
            _context.TipoFormacion.AddOrUpdate(
                new TipoFormacion { TipoFormacionId = 1, Nombre = "Secundaria"},
                new TipoFormacion { TipoFormacionId = 2, Nombre = "Tecnico" },
                new TipoFormacion { TipoFormacionId = 3, Nombre = "Universitario" },
                new TipoFormacion { TipoFormacionId = 4, Nombre = "Maestría" },
                new TipoFormacion { TipoFormacionId = 5, Nombre = "Doctorado" },
                new TipoFormacion { TipoFormacionId = 6, Nombre = "Otro" }
                );
        }
    }
}
