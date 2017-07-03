using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class Imagen
    {
        public long ImagenId { get; set; }
        public TipoImagen TipoImagen { get; set; }
        public string Nombre { get; set; }
        public Byte[] Archivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
