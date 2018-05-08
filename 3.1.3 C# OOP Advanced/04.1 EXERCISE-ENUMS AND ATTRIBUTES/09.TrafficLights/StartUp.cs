using System;
using System.Collections.Generic;
using TrafficLights.Enums;

namespace TrafficLights
{
    public class StartUp
    {
        public static void Main()
        {
            List<TrafficLight> allTrafficLights = new List<TrafficLight>();

            var inputSignals = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());

            foreach (var signal in inputSignals)
            {
                LightColor initialColorState = (LightColor)Enum.Parse(typeof(LightColor), signal);
                allTrafficLights.Add(new TrafficLight(initialColorState));
            }

            for (int i = 0; i < stateChangeCount; i++)
            {
                foreach (var trafficLight in allTrafficLights)
                {
                    trafficLight.NextState();
                }

                Console.WriteLine(string.Join(" ", allTrafficLights));
            }
        }
    }
}
