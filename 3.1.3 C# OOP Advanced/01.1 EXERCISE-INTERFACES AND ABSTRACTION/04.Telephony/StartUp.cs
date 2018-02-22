using System;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            var telNumbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            var smartphone = new Smartphone();

            foreach (var telNumber in telNumbers)
            {
                Console.WriteLine(smartphone.Call(telNumber));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
