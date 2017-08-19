using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var column = 2 * (n + 1) + n + (n + 1);
            var count = n;
            var stop = "STOP!";

            // First Line
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));

            // Upper Part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', count));
                Console.Write("//");
                Console.Write(new string('_', column - 2 * (count + 2)));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', count));
                count--;
            }

            // STOP Line
            Console.Write("//");
            Console.Write(new string('_', (column - 4 - stop.Length) / 2));
            Console.Write(stop);
            Console.Write(new string('_', (column - 4 - stop.Length) / 2));
            Console.WriteLine("\\\\");

            // Lower Part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\\\");
                Console.Write(new string('_', column - 4 - 2 * i));
                Console.Write("//");
                Console.WriteLine(new string('.', i));
            }

            //  OTHER SOLUTION!!!!!!!!!!!!  

            //  int n = int.Parse(Console.ReadLine());
            //  Console.WriteLine("{0}{1}{0}", new string ('.', n + 1), new string ('_', 2 * n + 1));
            //  int a = 2 * n - 1;
            //  for (int i = n; i >= 1; i--)
            //  {
            //      Console.WriteLine("{0}//{1}\\\\{0}", new string ('.', i), new string ('_', a));
            //      a += 2;
            //  }
            //   a = n * 2 - 3;
            //  Console.WriteLine("//{0}STOP!{0}\\\\", new string ('_', a));
            //  a = 4 * n - 1;
            //  for (int i = 0; i<n; i++)
            //  {
            //      Console.WriteLine("{0}\\\\{1}//{0}", new string ('.', i), new string ('_', a));
            //      a -= 2;
            //  }
        }
    }
}
