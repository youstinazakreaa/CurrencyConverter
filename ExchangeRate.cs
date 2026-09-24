using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton

{
    public class ExchangeRate
    {
        public ExchangeRate(string basecurrency, string targetcurrency, decimal rate)
        {
            BaseCurrency = basecurrency;

            TargetCurrency = targetcurrency;

            Rate = rate;
        }
    
    public string BaseCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public decimal Rate { get; set; }
    }
}
