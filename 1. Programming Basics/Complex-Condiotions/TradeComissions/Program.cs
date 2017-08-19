using System;

namespace TradeComissions
{
    class Program
    {
        static void Main()
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var comission = -1.0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 5 / 100;
                if (sales > 500 && sales <= 1000) comission = sales * 7 / 100;
                if (sales > 1000 && sales <= 10000) comission = sales * 8 / 100;
                if (sales > 10000) comission = sales * 12 / 100;
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 4.5 / 100;
                if (sales > 500 && sales <= 1000) comission = sales * 7.5 / 100;
                if (sales > 1000 && sales <= 10000) comission = sales * 10 / 100;
                if (sales > 10000) comission = sales * 13 / 100;
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) comission = sales * 5.5 / 100;
                if (sales > 500 && sales <= 1000) comission = sales * 8 / 100;
                if (sales > 1000 && sales <= 10000) comission = sales * 12 / 100;
                if (sales > 10000) comission = sales * 14.5 / 100;
            }

            if (comission >= 0)
            {
                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}