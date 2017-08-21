using System;
using System.Linq;

namespace _4_RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main()
        {
            string[] arrStr = Console.ReadLine()
                .Split(' ');

            string[] rotatedArr = new string[arrStr.Length];
            string lastElement = arrStr[arrStr.Length - 1];
            rotatedArr[0] = lastElement;

            for (int i = 0; i < arrStr.Length - 1; i++)
            {
                rotatedArr[i + 1] = arrStr[i];
            }

            string result = string.Join(" ", rotatedArr);
            Console.WriteLine(result);
        }
    }
}
