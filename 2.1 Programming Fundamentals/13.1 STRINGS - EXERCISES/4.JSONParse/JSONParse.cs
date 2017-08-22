using System;

namespace _4.JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            inputLine = inputLine.Substring(2, inputLine.Length - 2 - 2);

            var tokens = inputLine.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                var properties = token.Split(new string[] { "name:", ",age:", ",grades:" }, StringSplitOptions.RemoveEmptyEntries);

                var name = properties[0].Substring(1, properties[0].Length - 1 - 1);
                var age = properties[1];
                var grades = properties[2].Substring(1, properties[2].Length - 1 - 1);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
