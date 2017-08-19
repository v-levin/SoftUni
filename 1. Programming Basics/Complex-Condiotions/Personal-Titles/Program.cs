using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (gender == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (gender == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}