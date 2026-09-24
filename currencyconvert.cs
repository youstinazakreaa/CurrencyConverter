using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton
{
    public class currencyconvert
    {
        IEnumerable<ExchangeRate> exchangeRates;
        private currencyconvert()
        {
            loadExRate();
        }
        private static object Lock = new object ();

        private static currencyconvert _instance;
        public static currencyconvert Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Lock)
                        {
                            if (_instance == null)
                            {
                                _instance = new currencyconvert();
                            }
                        }
                }
                return _instance;
            }
        }
    
    public void loadExRate()
        {
            Thread.Sleep(2000);

            exchangeRates = new ExchangeRate[]
            {
            new ExchangeRate("USD", "EUR", 0.85m),
            new ExchangeRate("EUR", "USD", 1.18m),
            new ExchangeRate("USD", "GBP", 0.75m),
            new ExchangeRate("GBP", "USD", 1.33m),
            new ExchangeRate("EUR", "GBP", 0.88m),
            new ExchangeRate("GBP", "EUR", 1.14m)
            };
        }
        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            var rate = exchangeRates.FirstOrDefault(r => r.BaseCurrency == baseCurrency && r.TargetCurrency == targetCurrency);
            if (rate == null)
            {
                return 0;
            }
            return amount * rate.Rate;
        }
    }
}
