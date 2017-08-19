using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_06_Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerPokemons = int.Parse(Console.ReadLine());
            var secondPlayerPokemons = int.Parse(Console.ReadLine());
            var numberOfBattles = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 1; i <= firstPlayerPokemons; i++)
            {
                for (int j = 1; j <= secondPlayerPokemons; j++)
                {
                    count++;
                    Console.Write($"({i} <-> {j}) ");

                    if (count == numberOfBattles) break;
                }

                if (count == numberOfBattles) break;
            }
        }
    }
}
