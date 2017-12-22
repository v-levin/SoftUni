using System;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private int distanceTravelled;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionFor1km = fuelConsumptionFor1km;
            this.distanceTravelled = 0;
        }

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
        }

        public int DistanceTravelled
        {
            get { return this.distanceTravelled; }
        }

        public void Drive(int amountOfKm)
        {
            if (this.fuelAmount < amountOfKm * this.fuelConsumptionFor1km)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.distanceTravelled += amountOfKm;
                this.fuelAmount -= amountOfKm * fuelConsumptionFor1km;
            }
        }
    }
}
