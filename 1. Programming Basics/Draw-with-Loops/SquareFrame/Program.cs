using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            #region First Row
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            #endregion

            #region Middle Rows
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");

                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("|");
            }
            #endregion

            #region LastRow
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            #endregion
        }
    }
}
