using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class Persona
    {
        public long PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public long DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Resumen { get; set; }

        public long ImagenId { get; set; }
        public Imagen Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public List<Formacion> Estudios { get; set; }
        public List<ExperienciaLaboral> ExperienciaLaborales { get; set; }
        public List<ContactoPersona> DatosContacto { get; set; }
    }
}
