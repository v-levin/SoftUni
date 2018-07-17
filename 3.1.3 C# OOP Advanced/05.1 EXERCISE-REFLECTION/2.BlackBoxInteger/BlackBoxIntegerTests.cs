using System;
using System.Linq;
using System.Reflection;

namespace BlackBoxInteger
{
    public class BlackBoxIntegerTests
    {
        private const BindingFlags NonPublicFlags = BindingFlags.Instance | BindingFlags.NonPublic;

        public static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInteger);
            BlackBoxInteger myBlackBox = (BlackBoxInteger)Activator.CreateInstance(blackBoxType, true);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split('_');
                var methodName = tokens[0];
                var value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(methodName, NonPublicFlags)
                    .Invoke(myBlackBox, new object[] { value });

                var innerStateValue = blackBoxType
                    .GetFields(NonPublicFlags)
                    .First()
                    .GetValue(myBlackBox);

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
