using System;
using System.Collections.Generic;

namespace _3.Animals
{
    public class Animals
    {
        public class Dog
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int NumberOfLegs { get; set; }

            public static string ProduceSound()
            {
                return "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
            }
        }

        public class Cat
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int IntelligenceQuotient { get; set; }

            public static string ProduceSound()
            {
                return "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
            }
        }

        public class Snake
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int CrueltyCoefficient { get; set; }

            public static string ProduceSound()
            {
                return "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
            }
        }

        static List<Dog> dogs = new List<Dog>();
        static List<Cat> cats = new List<Cat>();
        static List<Snake> snakes = new List<Snake>();

        public static void Main()
        {
            var inputCommands = Console.ReadLine();

            while (inputCommands != "I'm your Huckleberry")
            {
                var inputParams = inputCommands.Split();

                if (inputParams[0] != "talk")
                {
                    var animalClass = inputParams[0];
                    var animalName = inputParams[1];
                    var animalAge = int.Parse(inputParams[2]);
                    var animalParameter = int.Parse(inputParams[3]);

                    AddAnimal(animalClass, animalName, animalAge, animalParameter);
                }
                else
                {
                    var animalName = inputParams[1];

                    var isDogName = CheckDogNames(animalName);
                    var isCatName = CheckCatNames(animalName);
                    var isSnakeName = CheckSnakeNames(animalName);

                    if (isDogName)
                    {
                        var produceSound = Dog.ProduceSound();
                        Console.WriteLine(produceSound);
                    }
                    else if (isCatName)
                    {
                        var produceSound = Cat.ProduceSound();
                        Console.WriteLine(produceSound);
                    }
                    else if (isSnakeName)
                    {
                        var produceSound = Snake.ProduceSound();
                        Console.WriteLine(produceSound);
                    }
                }

                inputCommands = Console.ReadLine();
            }

            PrintDogs();
            PrintCats();
            PrintSnakes();
        }

        static void PrintSnakes()
        {
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        static void PrintCats()
        {
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
        }

        static void PrintDogs()
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
        }

        static bool CheckSnakeNames(string animalName)
        {
            foreach (var snake in snakes)
            {
                if (animalName == snake.Name)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckCatNames(string animalName)
        {
            foreach (var cat in cats)
            {
                if (animalName == cat.Name)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckDogNames(string animalName)
        {
            foreach (var dog in dogs)
            {
                if (animalName == dog.Name)
                {
                    return true;
                }
            }

            return false;
        }

        static void AddAnimal(string animalClass, string animalName, int animalAge, int animalParameter)
        {
            switch (animalClass)
            {
                case "Dog":
                    AddDog(animalName, animalAge, animalParameter);
                    break;
                case "Cat":
                    AddCat(animalName, animalAge, animalParameter);
                    break;
                case "Snake":
                    AddSnake(animalName, animalAge, animalParameter);
                    break;
            }
        }

        private static void AddSnake(string animalName, int animalAge, int animalParameter)
        {
            var animal = new Snake()
            {
                Name = animalName,
                Age = animalAge,
                CrueltyCoefficient = animalParameter
            };

            snakes.Add(animal);
        }

        private static void AddCat(string animalName, int animalAge, int animalParameter)
        {
            var animal = new Cat()
            {
                Name = animalName,
                Age = animalAge,
                IntelligenceQuotient = animalParameter
            };

            cats.Add(animal);
        }

        private static void AddDog(string animalName, int animalAge, int animalParameter)
        {
            var animal = new Dog()
            {
                Name = animalName,
                Age = animalAge,
                NumberOfLegs = animalParameter
            };

            dogs.Add(animal);
        }
    }
}
