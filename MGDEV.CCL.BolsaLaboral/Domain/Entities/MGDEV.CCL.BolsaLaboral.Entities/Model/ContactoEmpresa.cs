using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class ContactoEmpresa
    {
        public long ContactoEmpresaId { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public string Contacto { get; set; }
        public Boolean Visible { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
