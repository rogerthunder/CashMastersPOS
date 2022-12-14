using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Models.Currencys
{
    public class US
    {
       public Dictionary<string, double> USValues = new Dictionary<string, double>
       {
           {"_oneHoundred", 100 },
           {"_fifty", 50 },
           {"_twenty", 20 },
           {"_ten", 10 },
           {"_five", 5 },
           {"_two", 2 },
           {"_one", 1 },
           {"_fiftyCents", .50 },
           {"_twentyFiveCents", .25 },
           {"_tenCents", .10 },
           {"_fiveCents", .05 },
           {"_oneCent", .01 }
       };

        public Dictionary<string, double> getValues()
        {
            return USValues;
        }
    }
}
