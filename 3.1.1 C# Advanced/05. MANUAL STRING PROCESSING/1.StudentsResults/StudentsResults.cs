using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.StudentsResults
{
    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var studentResults = new Dictionary<string, decimal[]>();
            
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var studentName = inputTokens[0];
                var results = inputTokens.Skip(1).Select(num => decimal.Parse(num)).ToArray();
                
                studentResults[studentName] = results;
            }

            Console.WriteLine(string.Format($"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average", 7}|"));

            foreach (var result in studentResults)
            {
                var studentName = result.Key;
                var results = result.Value;
                var average = results.Average();

                Console.WriteLine(string.Format($"{studentName,-10}|{results[0],7:F2}|{results[1],7:F2}|{results[2],7:F2}|{average,7:F4}|"));
            }
        }
    }
}
