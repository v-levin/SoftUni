using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            var blacklistedWords = Console.ReadLine()
                .Split(' ')
                .ToList();

            var filenames = Console.ReadLine();

            var result = new List<string>();

            while (!filenames.Equals("end"))
            {
                if (!blacklistedWords.Any(filenames.Contains))
                {
                    result.Add(filenames);
                }

                filenames = Console.ReadLine();
            }

            result.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
