using IteratorTest.Models;
using System;
using System.Linq;
using System.Reflection;

namespace IteratorTest
{
    public class Startup
    {
        public static void Main()
        {
            ExecuteCommands();
        }

        private static void ExecuteCommands()
        {
            try
            {
                var initializeCollection = Console.ReadLine().Split();
                var listIterator = new ListIterator(initializeCollection.Skip(1));

                var iteratorMethods = listIterator.GetType().GetMethods();

                var command = Console.ReadLine();

                while (!command.Equals("END"))
                {
                    try
                    {
                        var parsedMethod = iteratorMethods.FirstOrDefault(m => m.Name == command);

                        if (parsedMethod is null)
                            Console.WriteLine($"'{command}' method does not exist!");

                        Console.WriteLine(parsedMethod.Invoke(listIterator, new object[] { }));
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }


                    command = Console.ReadLine();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
