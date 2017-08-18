using System;
using System.Linq;

namespace _07_ResizableArray
{
    class ResizableArray
    {
        static void Main()
        {
            string[] comands = Console.ReadLine().Split(' ');
            int[] numbers = new int[4];
            int[] backupNumbers = new int[numbers.Length * 2];
            int push = 1;

            while (comands[0] != "end")
            {
                NewMethod(ref comands, ref numbers, backupNumbers, ref push);

                if (comands[0] == "pop")
                {
                    int count = 0;
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        if (comands[0] != "pop") break;

                        if (numbers[i] == 0) count++;

                        comands = Console.ReadLine().Split(' ');
                    }
                    
                    int[] popedArray = new int[numbers.Length - count];

                    for (int i = 0; i < popedArray.Length; i++)
                    {
                        popedArray[i] = numbers[i];
                    }

                    numbers = new int[popedArray.Length - 1];

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        numbers[j] = popedArray[j];
                    }
                }

                foreach (var number in numbers)
                {
                    if (number == 0) break;

                    Console.Write($"{number} ");
                }

                //else if (comands[0] == "pop")
                //{
                //    numbers[numbers.Length - 1] = null;
                //}
                //else if (comands[0] == "clear")
                //{
                //    for (int i = 0; i < comands.Length; i++)
                //    {
                //        numbers[i] = Array.Clear(comands, 0, comands.Length - 1);
                //    }
                //}

                if (comands[0] == "end") break;
            }

            Console.WriteLine();
        }

        private static void NewMethod(ref string[] comands, ref int[] numbers, int[] backupNumbers, ref int push)
        {
            if (comands[0] == "push")
            {

                for (int i = 0; i < int.MaxValue; i++)
                {
                    if (comands[0] != "push") break;

                    numbers[i] = int.Parse(comands[1]);
                    backupNumbers[i] = numbers[i];

                    push++;

                    if (push > numbers.Length)
                    {
                        numbers = new int[numbers.Length * 2];

                        for (int j = 0; j < numbers.Length; j++)
                        {
                            numbers[j] = backupNumbers[j];
                        }

                        push = 1;
                    }

                    comands = Console.ReadLine().Split(' ');
                }
            }
        }
    }
}
