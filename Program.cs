namespace singelton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter base currency (USD, EUR, GBP):");
                string baseCurrency = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter target currency (USD, EUR, GBP):");
                string targetCurrency = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter amount:");
                bool flag;

                decimal amount;
                do
                {

                    flag = decimal.TryParse(Console.ReadLine(), out amount);
           
                 
                } while (!flag);
                var convertedAmount = currencyconvert.Instance.Convert(baseCurrency, targetCurrency, amount);
                Console.WriteLine($"Converted amount: {convertedAmount}");

            }
        }
    }
}
