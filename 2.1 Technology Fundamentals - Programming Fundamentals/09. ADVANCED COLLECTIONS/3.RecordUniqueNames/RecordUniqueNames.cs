using System;
using System.Collections.Generic;

namespace _3.RecordUniqueNames
{
    class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var namesSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                namesSet.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, namesSet));
        }
    }
}
