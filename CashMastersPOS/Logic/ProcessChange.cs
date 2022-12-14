using CashMastersPOS.Models.Currencys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CashMastersPOS.Logic
{
    public class ProcessChange
    {
        /// <summary>
        /// Constructor which initialices the 2 dictionary which hold the currency type values
        /// </summary>
        public ProcessChange() {
            USChange = new Dictionary<string, int>();
            MexicoChange= new Dictionary<string, int>();
        }
        public Dictionary<string, int> USChange { get; set; }
        public Dictionary<string, int> MexicoChange { get; set; }

        public double totalChange = 0;
        public double change = 0;

        /// <summary>
        /// This method recieves the total purchased and the total payed with to make the difference 
        /// and also adds to the change to return list, so we can track how many bills or coins per Key we will be returning to the user
        /// Calculates in US currency
        /// </summary>
        public void calculateUS( double total, double payedWith)
        {
            change = Math.Round(payedWith - total, 2);
            
            var currency = new US();
            foreach (var currencyName in currency.getValues())
            {
                var residue =  change / currencyName.Value;
                change %= currencyName.Value;
                USChange.Add( currencyName.Value.ToString(), (int)residue);

            }

        }

        /// <summary>
        /// This method recieves the total purchased and the total payed with to make the difference 
        /// and also adds to the change to return list, so we can track how many bills or coins per Key we will be returning to the user
        /// Calculates in Mexican currency
        /// </summary>
        public void calculateMex(double total, double payedWith)
        {
            change = Math.Round(payedWith - total, 2);

            var currency = new Mexico();
            foreach (var currencyName in currency.getValues())
            {
                var residue = change / currencyName.Value;
                change %= currencyName.Value;
                USChange.Add(currencyName.Value.ToString(), (int)residue);

            }

        }
        /// <summary>
        /// Makes the current US change list and its values into a string
        /// </summary>
        public string returnChangeBillsCoins()
        {
            var temporary = new Dictionary<string, int>();

            var onlyValues = USChange.Where(s => s.Value != 0.0)
                          .ToDictionary(dict => dict.Key, dict => dict.Value);

            string labelValue = "";
            foreach (var item in onlyValues)
            {
                labelValue += $"Total {item.Key}s {item.Value} ; ";
            }
            return labelValue;
        }

        /// <summary>
        /// Makes the current Mexican change list and its values into a string
        /// </summary>
        public string returnChangeBillsCoinsMex()
        {
            var temporary = new Dictionary<string, int>();

            var onlyValues = MexicoChange.Where(s => s.Value != 0.0)
                          .ToDictionary(dict => dict.Key, dict => dict.Value);

            string labelValue = "";
            foreach (var item in onlyValues)
            {
                labelValue += $"Total {item.Key}s {item.Value} ; ";
            }
            return labelValue;
        }


        public string returnChangeTotalUS () {
            var listTemp = new List<double>();


            foreach (var item in USChange)
            {
                var value = Convert.ToDouble(item.Key) * item.Value;
                listTemp.Add(value);
            }
            var confirmTotal = Math.Round(listTemp.Sum(),2);
            return confirmTotal.ToString();
        }

    }
}
