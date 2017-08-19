using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var frame = 0;
            var afterMid = n - 4;

            if (n % 2 == 0)
            {
                frame = n - 2;

                for (int i = 0; i < n - 1; i++)
                {
                    var leftRight = frame / 2 - i;
                    if (leftRight >= 0)
                    {
                        Console.Write(new string('-', leftRight));
                        Console.Write("*");
                        Console.Write(new string('-', 2 * i));
                        Console.Write("*");
                        Console.WriteLine(new string('-', leftRight));
                    }
                    else
                    {
                        Console.Write(new string('-', Math.Abs(leftRight)));
                        Console.Write("*");
                        Console.Write(new string('-', afterMid));
                        Console.Write("*");
                        Console.WriteLine(new string('-', Math.Abs(leftRight)));
                        afterMid -= 2;
                    }
                }
            }
            else
            {
                frame = n - 1;

                for (int i = 0; i < n; i++)
                {
                    var leftRight = frame / 2 - i;
                    if (leftRight >= 0)
                    {
                        if (i == 0)
                        {
                            Console.Write(new string('-', leftRight));
                            Console.Write("*");
                            Console.WriteLine(new string('-', leftRight));
                        }
                        else
                        {
                            Console.Write(new string('-', leftRight));
                            Console.Write("*");
                            Console.Write(new string('-', 2 * i - 1));
                            Console.Write("*");
                            Console.WriteLine(new string('-', leftRight));
                        }
                    }
                    else
                    {
                        if (i == n - 1)
                        {
                            Console.Write(new string('-', Math.Abs(leftRight)));
                            Console.Write("*");
                            Console.WriteLine(new string('-', Math.Abs(leftRight)));
                        }
                        else
                        {
                            Console.Write(new string('-', Math.Abs(leftRight)));
                            Console.Write("*");
                            Console.Write(new string('-', afterMid));
                            Console.Write("*");
                            Console.WriteLine(new string('-', Math.Abs(leftRight)));
                            afterMid -= 2;
                        }
                    }
                }
            }
            
        }
    }
}
