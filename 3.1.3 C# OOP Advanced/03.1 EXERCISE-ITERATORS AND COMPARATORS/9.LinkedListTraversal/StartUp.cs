using System;

namespace LinkedListTraversal
{
    public class StartUp
    {
        public static void Main()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            var operationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var command = tokens[0];
                var number = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Add":
                        list.Add(number);
                        break;
                    case "Remove":
                        list.Remove(number);
                        break;
                }
            }

            Console.WriteLine(list.Count);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
