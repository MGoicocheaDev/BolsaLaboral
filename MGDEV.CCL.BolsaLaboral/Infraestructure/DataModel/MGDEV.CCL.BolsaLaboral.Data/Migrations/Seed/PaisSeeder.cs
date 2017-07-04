
using MGDEV.CCL.BolsaLaboral.Data.Model;
using MGDEV.CCL.BolsaLaboral.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Data.Migrations.Seed
{
    public static class PaisSeeder
    {
        public static void addPais(EFBolsaLaboralContext _context)
        {
            var region = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                    .Select(x => new RegionInfo(x.LCID));

            var countries = (from x in region
                             select new { TwoLetterIso = x.TwoLetterISORegionName, DisplayName = x.EnglishName,  IsoCurrentSymbol = x.ISOCurrencySymbol })
                         .Distinct()
                         .OrderBy(x => x.DisplayName)
                         .ToList();

            int i = 0;
            foreach(var country in countries)
            { i++;
                _context.Pais.AddOrUpdate(
                    new Pais { PaisId =i , DisplayName = country.DisplayName, ISOCurrencySymbol = country.IsoCurrentSymbol, TwoLetterISO = country.TwoLetterIso}
                    );
            }

        }
    }
}
