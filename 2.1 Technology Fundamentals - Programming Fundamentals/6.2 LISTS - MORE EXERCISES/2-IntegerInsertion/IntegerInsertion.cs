using System;
using System.Linq;

namespace _2_IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var number = Console.ReadLine();

            while (!number.Equals("end"))
            {
                var numberToInt = int.Parse(number);
                var position = int.Parse(number);

                while (position > 10)
                {
                    position /= 10;
                }

                numbers.Insert(position, numberToInt);

                number = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
