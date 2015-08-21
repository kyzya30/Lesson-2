using System;


namespace HW_methods_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу валюту - UAH, USD, EUR");
            string Currency = Console.ReadLine();
            Console.WriteLine("Введите сумму данной валюты:");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите валюту в которую хотите перевести деньги - UAH, USD, EUR");
            string convertibleCurrency = Console.ReadLine();

            if(Currency == "UAH" && convertibleCurrency == "USD")
            { UAHtoUSD(sum); }
            if (Currency == "UAH" && convertibleCurrency == "EUR")
            { UAHtoEUR(sum); }
            if (Currency == "USD" && convertibleCurrency == "UAH")
            { USDtoUAH(sum); }
            if (Currency == "USD" && convertibleCurrency == "EUR")
            { USDtoEUR(sum); }
            if (Currency == "EUR" && convertibleCurrency == "UAH")
            {
            double result =    EURtoUAH(sum);
            Console.WriteLine("{0} EUR to UAH is {1:F3}", sum, result);
            }
            if (Currency == "EUR" && convertibleCurrency == "USD")
            {
                double result =  EURtoUSD(sum);
                Console.WriteLine("{0} EUR to USD is {1:F3}", sum, result);
            }

        }
        static double EURtoUSD(double sum)
        {
            double result = sum * 1.0702;
            return result;
        }
        static double EURtoUAH(double sum)
        {
           double result = sum * 24;
            return result;

        }
        static void UAHtoUSD(double sum)
        { Console.WriteLine("{0} UAH to USD is {1:F2}",sum, sum/23.52 ); }
        static void UAHtoEUR(double sum)
        { Console.WriteLine("{0} UAH to EUR is {1:F2}", sum, sum / 26.04); }
        static void USDtoUAH(double sum)
        { Console.WriteLine("{0} USD to UAH is {1:F3}", sum, sum * 21.50); }
        static void USDtoEUR(double sum)
        { Console.WriteLine("{0} USD to EUR is {1:F3}", sum, sum / 1.1095); }
    }
}