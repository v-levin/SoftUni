using System;
using System.Text;

namespace _08.MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart(new[] { '0' });
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum == "0" || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var numberInMind = 0;
            var result = new StringBuilder();
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                var product = int.Parse(firstNum[i].ToString()) * secondNum + numberInMind;
                var reminder = product % 10;
                numberInMind = product / 10;

                result.Insert(0, reminder);

                if (i == 0 && numberInMind != 0)
                {
                    result.Insert(0, numberInMind);
                }
            }

            Console.WriteLine(result);
        }
    }
}
