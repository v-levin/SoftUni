using Animals.Models.Animals;
using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    var animalInfo = Console.ReadLine().Split();

                    switch (input)
                    {
                        case "Dog":
                            var dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                            var cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Frog":
                            var frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(tomcat);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
