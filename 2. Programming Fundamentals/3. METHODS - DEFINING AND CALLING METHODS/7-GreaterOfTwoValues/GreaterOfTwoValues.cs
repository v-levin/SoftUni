using System;

namespace _7_GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int value1 = int.Parse(Console.ReadLine());
                        int value2 = int.Parse(Console.ReadLine());

                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }

                case "char":
                    {
                        char value1 = char.Parse(Console.ReadLine());
                        char value2 = char.Parse(Console.ReadLine());

                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }

                case "string":
                    {
                        string value1 = Console.ReadLine();
                        string value2 = Console.ReadLine();

                        var greater = Max(value1, value2);
                        Console.WriteLine(greater);
                        break;
                    }
            }
        }

        static int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }

            return num2;
        }

        static char Max(char ch1, char ch2)
        {
            int char1Int = ch1;
            int char2Int = ch2;
            return (char)Max(char1Int, char2Int);
        }

        static string Max(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }

            return str2;
        }
    }
}
