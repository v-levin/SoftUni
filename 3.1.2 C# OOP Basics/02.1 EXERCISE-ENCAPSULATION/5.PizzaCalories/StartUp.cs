using System;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var pizzaInfo = inputLine.Split();
                switch (pizzaInfo[0].ToLower())
                {
                    case "dough":
                        try
                        {
                            var dough = new Dough(pizzaInfo[1], pizzaInfo[2], int.Parse(pizzaInfo[3]));
                            Console.WriteLine($"{dough.GetCalories():f2}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    case "topping":
                        try
                        {
                            var topping = new Topping(pizzaInfo[1], int.Parse(pizzaInfo[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    case "pizza":
                        var pizzaName = pizzaInfo[1];
                        var numberOfToppings = int.Parse(pizzaInfo[2]);

                        if (numberOfToppings > 10)
                        {
                            Console.WriteLine("Number of toppings should be in range [0..10].");
                            return;
                        }

                        var doughParams = Console.ReadLine().Split();
                        Pizza pizza;
                        try
                        {
                            var dough = new Dough(doughParams[1], doughParams[2], int.Parse(doughParams[3]));
                            pizza = new Pizza(pizzaName, dough);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }

                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            var toppingInfo = Console.ReadLine().Split();
                            var toppingName = toppingInfo[1];
                            var toppingWeight = int.Parse(toppingInfo[2]);
                            
                            try
                            {
                                var topping = new Topping(toppingName, toppingWeight);
                                pizza.AddTopping(topping);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                return;
                            }
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");

                        break;
                }
                
            }
        }
    }
}
