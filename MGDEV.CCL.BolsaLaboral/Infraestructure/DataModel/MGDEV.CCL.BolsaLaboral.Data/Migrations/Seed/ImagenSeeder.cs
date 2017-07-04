using Bogus;
using MGDEV.CCL.BolsaLaboral.Data.Model;
using MGDEV.CCL.BolsaLaboral.Entities.Enum;
using MGDEV.CCL.BolsaLaboral.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Data.Migrations.Seed
{
    public static class ImagenSeeder
    {
        public static void addImage(EFBolsaLaboralContext _context)
        {
            for(int i = 1; i<= 10; i++)
            {
                var faker = new Faker();
                string imagen = faker.Internet.Avatar();
                
                var webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(imagen);

                //string filename = string.Empty;
                //string extension = string.Empty;
                
                //filename=System.IO.Path.GetFileName(new Uri(imagen).AbsolutePath);
                //extension= System.IO.Path.GetFileName(new Uri(imagen).AbsolutePath).Split('.')[1];

                int ext = 1;
          

                _context.Imagen.AddOrUpdate(
                    new Imagen
                    {
                        ImagenId = i,
                        Archivo = imageBytes,
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                        Nombre = imagen,
                        TipoImagen = (TipoImagen)ext
                    });
                    

            }

            
        }
    }
}
