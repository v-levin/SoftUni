using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> iterator = null;

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var inputArgs = inputLine.Split();

                switch (inputArgs[0])
                {
                    case "Create":
                        iterator = new ListyIterator<string>(inputArgs.Skip(1));
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
            }
        }
    }
}
