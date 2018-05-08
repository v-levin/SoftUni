using System;
using TrafficLights.Enums;

namespace TrafficLights
{
    public class TrafficLight
    {
        private LightColor colorState;

        public TrafficLight(LightColor colorState)
        {
            this.colorState = colorState;
        }

        public void NextState()
        {
            this.colorState = (LightColor)((int)(this.colorState + 1) % Enum.GetNames(typeof(LightColor)).Length);
        }

        public override string ToString()
        {
            return this.colorState.ToString();
        }
    }
}
