using System;

namespace CypherRoulette
{
    class CypherRoulette
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string prevString = string.Empty;
            bool leftAppend = false;

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();

                if (prevString == currString)
                {
                    if (prevString == "spin" && currString == "spin")
                    {
                        result = string.Empty;
                        i--;
                        continue;
                    }

                    result = string.Empty;
                    continue;
                }

                if (currString == "spin")
                {
                    leftAppend = !leftAppend;
                    i--;
                }
                else if (leftAppend)
                {
                    result = currString + result;
                }
                else if (!leftAppend)
                {
                    result += currString;
                }

                prevString = currString;
            }

            Console.WriteLine(result);
        }
    }
}
