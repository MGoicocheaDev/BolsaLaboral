using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class Domicilio
    {
        public long DomicilioId { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public string Direccion { get; set; }
        public string Seccion { get; set; }
        public string Urbanizacion { get; set; }
        public string CodigoUbigeo { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set;}
    }
}
