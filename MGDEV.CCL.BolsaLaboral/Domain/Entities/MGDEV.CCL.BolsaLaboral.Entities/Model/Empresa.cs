using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class Empresa
    {
        public long EmpresaId { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public string Descripcion { get; set; }
        public long DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
        public string ActividadEmpresa { get; set; }
        public long ImagenId { get; set; }
        public Imagen Imagen { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public List<ContactoEmpresa> DatosContactoEmpresa { get; set; }


    }
}
