using System;
using System.Collections.Generic;

namespace PracticeList
{
    class Program
    {
        static void Main()
        {

            DateTime startTime = DateTime.Now;
            var list = new List<string>() { "C#", "JAVA" };
            list.Add("SQL");
            list.Add("Python");
            list.Add("PHP");
            list.Add("Swift");
            list.Add("Go");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(DateTime.Now - startTime);
        }
    }
}