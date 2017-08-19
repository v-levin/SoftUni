using System;

namespace MetricConverter
{
    class Program
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            #region Input
            if (inputMetric == "mm")
            {
                num /= 1000;
            }
            else if (inputMetric == "cm")
            {
                num /= 100;
            }
            else if (inputMetric == "mi")
            {
                num /= 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                num /= 39.3700787;
            }
            else if (inputMetric == "km")
            {
                num /= 0.001;
            }
            else if (inputMetric == "ft")
            {
                num /= 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                num /= 1.0936133;
            }
            #endregion

            #region Output
            if (outputMetric == "mm")
            {
                num *= 1000;
            }
            else if (outputMetric == "cm")
            {
                num *= 100;
            }
            else if (outputMetric == "mi")
            {
                num *= 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                num *= 39.3700787;
            }
            else if (outputMetric == "km")
            {
                num *= 0.001;
            }
            else if (outputMetric == "ft")
            {
                num *= 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                num *= 1.0936133;
            }
            #endregion

            Console.WriteLine($"{num} {outputMetric}");

        }
    }
}