﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGDEV.CCL.BolsaLaboral.Entities.Model
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string DisplayName { get; set; }
        public string TwoLetterISO { get; set; }
        public string ISOCurrencySymbol { get; set; }
    }
}
