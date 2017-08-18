using System;

namespace _3_PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significantThreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double div = GetDiversity(lastPrice, currentPrice);
                bool isSignificantDifference = IsSignificantDifference(div, significantThreshold);
                string message = GetMessage(currentPrice, lastPrice, div, isSignificantDifference);

                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string message = string.Empty;

            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            return message;
        }

        private static bool IsSignificantDifference(double div, double significantThreshold)
        {
            if (Math.Abs(div) >= significantThreshold)
            {
                return true;
            }

            return false;
        }

        private static double GetDiversity(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;

            return result;
        }
    }
}
