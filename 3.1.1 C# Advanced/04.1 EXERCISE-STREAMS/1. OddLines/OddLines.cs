using System;
using System.IO;

namespace _1.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../test.txt"))
            {
                var readLine = string.Empty;
                var counter = 1;
                while ((readLine = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(readLine);
                    }

                    counter++;
                }
            }
        }
    }
}
