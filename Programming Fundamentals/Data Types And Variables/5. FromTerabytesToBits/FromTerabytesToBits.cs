using System;

namespace FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main()
        {
            double teraBytes = double.Parse(Console.ReadLine());

            Console.WriteLine(teraBytes * 1024 * 1024 * 1024 * 1024 * 8);

        }
    }
}
