using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Models.Currencys
{
    public class Mexico
    {
        public Dictionary<string, double> MexicoValues = new Dictionary<string, double>
       {
           {"_cien", 100 },
           {"_cincuenta", 50 },
           {"_veinte", 20 },
           {"_diez", 10 },
           {"_cinco", 5 },
           {"_dos", 2 },
           {"_uno", 1 },
           {"_cincuentaCentavos", .50 },
           {"_veinteCentavos", .20 },
           {"_diezCentavos", .10 },
           {"_cincoCentavos", .05 },
       };

        public Dictionary<string, double> getValues()
        {
            return MexicoValues;
        }
    }
}
