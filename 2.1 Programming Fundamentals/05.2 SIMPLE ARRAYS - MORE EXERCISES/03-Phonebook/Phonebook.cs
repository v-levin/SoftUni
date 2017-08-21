using System;

namespace _03_Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string name = Console.ReadLine();

            while (name != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}
