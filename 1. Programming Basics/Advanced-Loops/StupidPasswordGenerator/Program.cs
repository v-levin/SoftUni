using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = int.Parse(Console.ReadLine());
            var letters = int.Parse(Console.ReadLine());

            const string lettersAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 1; i < nums; i++)
            {
                for (int j = 1; j < nums; j++)
                {
                    for (int k = 0; k < letters; k++)
                    {
                        var kLetter = lettersAlphabet.ToLower()[k];

                        for (int l = 0; l < letters; l++)
                        {
                            var lLetter = lettersAlphabet.ToLower()[l];

                            for (int m = 1; m <= nums; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{kLetter}{lLetter}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
