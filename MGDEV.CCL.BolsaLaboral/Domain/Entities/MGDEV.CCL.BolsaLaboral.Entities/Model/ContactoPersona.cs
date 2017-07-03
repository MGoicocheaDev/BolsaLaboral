using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class ContactoPersona
    {
        public long ContactoPersonaId { get; set; }
        public long PersonaId { get; set; }
        public Persona Persona { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
