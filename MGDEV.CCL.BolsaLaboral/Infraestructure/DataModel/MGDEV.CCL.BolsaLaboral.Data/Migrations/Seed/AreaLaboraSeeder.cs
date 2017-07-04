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
    public static class AreaLaboraSeeder
    {

        public static void addAreaLaboral(EFBolsaLaboralContext _context)
        {
            _context.AreaLaboral.AddOrUpdate(
                new AreaLaboral { AreaLaboralId = 1, Nombre = "Administración, Contabilidad y Finanzas" },
                new AreaLaboral { AreaLaboralId = 2 , Nombre = "Aduanas y Comercio Exterior" },
                new AreaLaboral { AreaLaboralId = 3, Nombre = "Almacén / Logística / Transporte" },
                new AreaLaboral { AreaLaboralId = 4, Nombre = "Atención al Cliente" },
                new AreaLaboral { AreaLaboralId = 5, Nombre = "Call center / Telemarketing" },
                new AreaLaboral { AreaLaboralId = 6, Nombre = "Comercial / Ventas" },
                new AreaLaboral { AreaLaboralId = 7, Nombre = "Construcción / Obra" },
                new AreaLaboral { AreaLaboralId = 8, Nombre = "Diseño / Artes gráficas" },
                new AreaLaboral { AreaLaboralId = 9, Nombre = "Educación" },
                new AreaLaboral { AreaLaboralId = 10, Nombre = "Gastronomía" },
                new AreaLaboral { AreaLaboralId = 11, Nombre = "Gerencia / Dirección" },
                new AreaLaboral { AreaLaboralId = 12, Nombre = "Hotelería / Turismo" },
                new AreaLaboral { AreaLaboralId = 13, Nombre = "Ingeniería" },
                new AreaLaboral { AreaLaboralId = 14, Nombre = "Investigación y Calidad" },
                new AreaLaboral { AreaLaboralId = 15, Nombre = "Legal" },
                new AreaLaboral { AreaLaboralId = 16, Nombre = "Mantenimiento / Limpieza" },
                new AreaLaboral { AreaLaboralId = 17, Nombre = "Marketing / Publicidad / Comunicación" },
                new AreaLaboral { AreaLaboralId = 18, Nombre = "Medicina / Salud" },
                new AreaLaboral { AreaLaboralId = 19, Nombre = "Minería, Petróleo y Gas" },
                new AreaLaboral { AreaLaboralId = 20, Nombre = "Oficios y Otros" },
                new AreaLaboral { AreaLaboralId = 21, Nombre = "Producción / Operaciones" },
                new AreaLaboral { AreaLaboralId = 22, Nombre = "Proyectos" },
                new AreaLaboral { AreaLaboralId = 23, Nombre = "Recursos Humanos" },
                new AreaLaboral { AreaLaboralId = 24, Nombre = "Relaciones institucionales / públicas" },
                new AreaLaboral { AreaLaboralId = 25, Nombre = "Secretarias y Recepción" },
                new AreaLaboral { AreaLaboralId = 26, Nombre = "Seguridad" },
                new AreaLaboral { AreaLaboralId = 27, Nombre = "Tecnología, Sistemas y Telecomunicaciones" }
                );
        }
    }
}
