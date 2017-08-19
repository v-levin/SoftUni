using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_01_Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumriaKg = double.Parse(Console.ReadLine());
            var priceCacaKg = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = int.Parse(Console.ReadLine());

            var palamudPrice = priceSkumriaKg + priceSkumriaKg * 0.6;
            var palamudSum = palamudKg * palamudPrice;

            var safridPrice = priceCacaKg + priceCacaKg * 0.8;
            var safridSum = safridKg * safridPrice;

            var midiSum = midiKg * 7.5;

            var totalSum = palamudSum + safridSum + midiSum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
