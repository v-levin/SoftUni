using System;
using System.Text.RegularExpressions;

namespace _04_Phone
{
    class Phone
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] action = Console.ReadLine().Split(' ');

            long[] telNum = new long[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                telNum[i] = long.Parse(Regex.Replace(numbers[i], @"\D+", ""));
            }

            while (!action[0].Equals("done"))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (action[0].Equals("call") && action[1].Equals(numbers[i]))
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        CallingResult(telNum, i);
                        break;
                    }
                    else if (action[0].Equals("call") && action[1].Equals(names[i]))
                    {
                        Console.WriteLine($"calling {numbers[i]}...");
                        CallingResult(telNum, i);
                        break;
                    }

                    if (action[0].Equals("message") && action[1].Equals(numbers[i]))
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        MessagingResult(telNum, i);
                        break;
                    }
                    else if (action[0].Equals("message") && action[1].Equals(names[i]))
                    {
                        Console.WriteLine($"sending sms to {numbers[i]}...");
                        MessagingResult(telNum, i);
                        break;
                    }
                }

                action = Console.ReadLine().Split(' ');
            }
        }

        static void CallingResult(long[] telNum, int i)
        {
            int sum = DigitSum(telNum, i);

            if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                int min = sum / 60;
                int sec = sum % 60;

                Console.WriteLine($"call ended. duration: {min:D2}:{sec:D2}");
            }
        }

        static void MessagingResult(long[] telNum, int i)
        {
            int sum = DigitSum(telNum, i);

            if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        static int DigitSum(long[] telNum, int i)
        {
            int sum = 0;
            long telNumber = telNum[i];

            while (telNumber > 0)
            {
                sum += (int)(telNumber % 10);
                telNumber /= 10;
            }

            return sum;
        }
    }
}
