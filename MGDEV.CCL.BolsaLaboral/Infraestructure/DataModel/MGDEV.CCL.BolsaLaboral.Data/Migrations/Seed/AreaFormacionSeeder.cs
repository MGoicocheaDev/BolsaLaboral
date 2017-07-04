﻿using MGDEV.CCL.BolsaLaboral.Data.Model;
using MGDEV.CCL.BolsaLaboral.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Data.Migrations.Seed
{
    public static class AreaFormacionSeeder
    {

        public static void addAreaFormacion(EFBolsaLaboralContext _context)
        {

            _context.AreaFormacion.AddOrUpdate(
                new AreaFormacion { AreaFormacionId = 1, Nombre = "Abogacía / Derecho / Leyes" },
                new AreaFormacion { AreaFormacionId = 2, Nombre = "Administración de Empresas" },
                new AreaFormacion { AreaFormacionId = 3, Nombre = "Administración y Gestión Pública" },
                new AreaFormacion { AreaFormacionId = 4, Nombre = "Administración Agropecuaria" },
                new AreaFormacion { AreaFormacionId = 5, Nombre = "Agronegocios" },
                new AreaFormacion { AreaFormacionId = 6, Nombre = "Antropología" },
                new AreaFormacion { AreaFormacionId = 7, Nombre = "Análisis de Sistemas" },
                new AreaFormacion { AreaFormacionId = 8, Nombre = "Apoderado Aduanal" },
                new AreaFormacion { AreaFormacionId = 9, Nombre = "Arqueología" },
                new AreaFormacion { AreaFormacionId = 10, Nombre = "Arquitectura" },
                new AreaFormacion { AreaFormacionId = 11, Nombre = "Asesoría Legal Internacional" },
                new AreaFormacion { AreaFormacionId = 12, Nombre = "Asesoría en Comercio Exterior" },
                new AreaFormacion { AreaFormacionId = 13, Nombre = "Astronomía" },
                new AreaFormacion { AreaFormacionId = 14, Nombre = "Bellas Artes" },
                new AreaFormacion { AreaFormacionId = 15, Nombre = "Bibliotecología" },
                new AreaFormacion { AreaFormacionId = 16, Nombre = "BioFisica" },
                new AreaFormacion { AreaFormacionId = 17, Nombre = "Bioingeniería" },
                new AreaFormacion { AreaFormacionId = 18, Nombre = "Biología" },
                new AreaFormacion { AreaFormacionId = 19, Nombre = "Bioquímica" },
                new AreaFormacion { AreaFormacionId = 20, Nombre = "Biotecnología" },
                new AreaFormacion { AreaFormacionId = 21, Nombre = "Capacitación Comercio Exterior" },
                new AreaFormacion { AreaFormacionId = 22, Nombre = "Cartografía" },
                new AreaFormacion { AreaFormacionId = 23, Nombre = "Ciencias Físicas" },
                new AreaFormacion { AreaFormacionId = 24, Nombre = "Ciencias de los Alimentos" },
                new AreaFormacion { AreaFormacionId = 25, Nombre = "Ciencias Políticas" },
                new AreaFormacion { AreaFormacionId = 26, Nombre = "Ciencias de la Educación" },
                new AreaFormacion { AreaFormacionId = 27, Nombre = "Ciencias del Ejercicio / Educacion Física" },
                new AreaFormacion { AreaFormacionId = 28, Nombre = "Comercio Interior / Exterior" },
                new AreaFormacion { AreaFormacionId = 29, Nombre = "Compras Internacionales / Importación" },
                new AreaFormacion { AreaFormacionId = 30, Nombre = "Computación / Informática" },
                new AreaFormacion { AreaFormacionId = 31, Nombre = "Comunicación Audiovisual" },
                new AreaFormacion { AreaFormacionId = 32, Nombre = "Comunicación Social" },
                new AreaFormacion { AreaFormacionId = 33, Nombre = "Construcción / Obras Civiles" },
                new AreaFormacion { AreaFormacionId = 34, Nombre = "Consultorías Comercio Exterior" },
                new AreaFormacion { AreaFormacionId = 35, Nombre = "Contabilidad / Auditoría" },
                new AreaFormacion { AreaFormacionId = 36, Nombre = "Dibujo Técnico" },
                new AreaFormacion { AreaFormacionId = 37, Nombre = "Diseño Gráfico" },
                new AreaFormacion { AreaFormacionId = 38, Nombre = "Diseño Industrial" },
                new AreaFormacion { AreaFormacionId = 39, Nombre = "Diseño Web" },
                new AreaFormacion { AreaFormacionId = 40, Nombre = "Diseño de Imagen y Sonido" },
                new AreaFormacion { AreaFormacionId = 41, Nombre = "Diseño de Vestuario / Textil / Modas" },
                new AreaFormacion { AreaFormacionId = 42, Nombre = "Ecología" },
                new AreaFormacion { AreaFormacionId = 43, Nombre = "Economía" },
                new AreaFormacion { AreaFormacionId = 44, Nombre = "Educacion" },
                new AreaFormacion { AreaFormacionId = 45, Nombre = "Electricidad" },
                new AreaFormacion { AreaFormacionId = 46, Nombre = "Electrónica" },
                new AreaFormacion { AreaFormacionId = 47, Nombre = "Enfermería" },
                new AreaFormacion { AreaFormacionId = 48, Nombre = "Estadística" },
                new AreaFormacion { AreaFormacionId = 49, Nombre = "Farmacia" },
                new AreaFormacion { AreaFormacionId = 50, Nombre = "Filosofía" },
                new AreaFormacion { AreaFormacionId = 51, Nombre = "Finanzas" },
                new AreaFormacion { AreaFormacionId = 52, Nombre = "Fisioterapia" },
                new AreaFormacion { AreaFormacionId = 53, Nombre = "Fotografía" },
                new AreaFormacion { AreaFormacionId = 54, Nombre = "Gastronomía / Cocina" },
                new AreaFormacion { AreaFormacionId = 55, Nombre = "Geofísica" },
                new AreaFormacion { AreaFormacionId = 56, Nombre = "Geografía" },
                new AreaFormacion { AreaFormacionId = 57, Nombre = "Geología / Geomensura / Topografía" },
                new AreaFormacion { AreaFormacionId = 58, Nombre = "Hidráulica" },
                new AreaFormacion { AreaFormacionId = 59, Nombre = "Historia" },
                new AreaFormacion { AreaFormacionId = 60, Nombre = "Hotelería" },
                new AreaFormacion { AreaFormacionId = 61, Nombre = "Ing. - otros" },
                new AreaFormacion { AreaFormacionId = 62, Nombre = "Ing.Aerospacial" },
                new AreaFormacion { AreaFormacionId = 63, Nombre = "Ing.Agropecuario " },
                new AreaFormacion { AreaFormacionId = 64, Nombre = "Ing.Agrónomo" },
                new AreaFormacion { AreaFormacionId = 65, Nombre = "Ing.Alimentos" },
                new AreaFormacion { AreaFormacionId = 66, Nombre = "Ing.Ambiental" },
                new AreaFormacion { AreaFormacionId = 67, Nombre = "Ing.Civil" },
                new AreaFormacion { AreaFormacionId = 68, Nombre = "Ing.Electrónica" },
                new AreaFormacion { AreaFormacionId = 69, Nombre = "Ing.Eléctrica" },
                new AreaFormacion { AreaFormacionId = 70, Nombre = "Ing.Forestal" },
                new AreaFormacion { AreaFormacionId = 71, Nombre = "Ing.Hidraúlica" },
                new AreaFormacion { AreaFormacionId = 72, Nombre = "Ing.Industrial" },
                new AreaFormacion { AreaFormacionId = 73, Nombre = "Ing.Informática" },
                new AreaFormacion { AreaFormacionId = 74, Nombre = "Ing.Matemática" },
                new AreaFormacion { AreaFormacionId = 75, Nombre = "Ing.Mecánica / Metalúrgica" },
                new AreaFormacion { AreaFormacionId = 76, Nombre = "Ing.Naval" },
                new AreaFormacion { AreaFormacionId = 77, Nombre = "Ing.Nuclear" },
                new AreaFormacion { AreaFormacionId = 78, Nombre = "Ing.Obras Civiles / Construcción" },
                new AreaFormacion { AreaFormacionId = 79, Nombre = "Ing.Pesquera / Cultivos Marinos" },
                new AreaFormacion { AreaFormacionId = 80, Nombre = "Ing.Petróleo" },
                new AreaFormacion { AreaFormacionId = 81, Nombre = "Ing.Química" },
                new AreaFormacion { AreaFormacionId = 82, Nombre = "Ing.Recursos Hídricos" },
                new AreaFormacion { AreaFormacionId = 83, Nombre = "Ing.Sonido" },
                new AreaFormacion { AreaFormacionId = 84, Nombre = "Ing.Telecomunicaciones" },
                new AreaFormacion { AreaFormacionId = 85, Nombre = "Ing.Transporte" },
                new AreaFormacion { AreaFormacionId = 86, Nombre = "Ing.en Minas" },
                new AreaFormacion { AreaFormacionId = 87, Nombre = "Ing.en Sistemas" },
                new AreaFormacion { AreaFormacionId = 88, Nombre = "Ingeniero vial" },
                new AreaFormacion { AreaFormacionId = 89, Nombre = "Intérprete" },
                new AreaFormacion { AreaFormacionId = 90, Nombre = "Laboratorio(Mecánica) Dental" },
                new AreaFormacion { AreaFormacionId = 91, Nombre = "Literatura" },
                new AreaFormacion { AreaFormacionId = 92, Nombre = "Marketing / Comercialización" },
                new AreaFormacion { AreaFormacionId = 93, Nombre = "Matemáticas" },
                new AreaFormacion { AreaFormacionId = 94, Nombre = "Mecánica / Metalúrgica " },
                new AreaFormacion { AreaFormacionId = 95, Nombre = "Medicina" },
                new AreaFormacion { AreaFormacionId = 96, Nombre = "Medio Ambiente" },
                new AreaFormacion { AreaFormacionId = 97, Nombre = "Minería / Petróleo / Gas" },
                new AreaFormacion { AreaFormacionId = 98, Nombre = "Nutrición" },
                new AreaFormacion { AreaFormacionId = 99, Nombre = "Odontología" },
                new AreaFormacion { AreaFormacionId = 100, Nombre = "Otra" },
                new AreaFormacion { AreaFormacionId = 101, Nombre = "Periodismo" },
                new AreaFormacion { AreaFormacionId = 102, Nombre = "Psicología" },
                new AreaFormacion { AreaFormacionId = 103, Nombre = "Psicopedagogía" },
                new AreaFormacion { AreaFormacionId = 104, Nombre = "Publicidad" },
                new AreaFormacion { AreaFormacionId = 105, Nombre = "Relaciones Internacionales" },
                new AreaFormacion { AreaFormacionId = 106, Nombre = "Secretariado" },
                new AreaFormacion { AreaFormacionId = 107, Nombre = "Seguridad Industrial " },
                new AreaFormacion { AreaFormacionId = 108, Nombre = "Seguros" },
                new AreaFormacion { AreaFormacionId = 109, Nombre = "Sociología" },
                new AreaFormacion { AreaFormacionId = 110, Nombre = "Tecnico" },
                new AreaFormacion { AreaFormacionId = 111, Nombre = "Tecnología Médica / Laboratorio" },
                new AreaFormacion { AreaFormacionId = 112, Nombre = "Tecnología de Alimentos" },
                new AreaFormacion { AreaFormacionId = 113, Nombre = "Tecnologías de la Información" },
                new AreaFormacion { AreaFormacionId = 114, Nombre = "Telecomunicaciones" },
                new AreaFormacion { AreaFormacionId = 115, Nombre = "Terapia Ocupacional" },
                new AreaFormacion { AreaFormacionId = 116, Nombre = "Trabajo Social" },
                new AreaFormacion { AreaFormacionId = 117, Nombre = "Traducción" },
                new AreaFormacion { AreaFormacionId = 118, Nombre = "Transporte" },
                new AreaFormacion { AreaFormacionId = 119, Nombre = "Turismo" },
                new AreaFormacion { AreaFormacionId = 120, Nombre = "Ventas Internacionales / Exportación" },
                new AreaFormacion { AreaFormacionId = 121, Nombre = "Veterinaria" }
                );
        }
    }
}