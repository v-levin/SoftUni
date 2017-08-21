using System;

namespace _2_MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 0;

            if (num1 > num2 && num1 > num3)
            {
                firstNum = num2;
                secondNum = num3;
            }
            else if (num2 > num1 && num2 > num3)
            {
                firstNum = num1;
                secondNum = num3;
            }
            else if (num3 > num1 && num3 > num2)
            {
                firstNum = num1;
                secondNum = num2;
            }

            int minNum = GetMin(firstNum, secondNum);

            Console.WriteLine(minNum);
        }

        static int GetMin(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return secondNum;
            }

            return firstNum;
        }
    }
}
