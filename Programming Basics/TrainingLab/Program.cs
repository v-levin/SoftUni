using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var width = Math.Floor(w * 100 / 120);
            var height = Math.Floor((h * 100 - 100) / 70);

            var result = width * height - 3;

            Console.WriteLine(result);
        }
    }
}
