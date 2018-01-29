﻿namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLossFactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod, tankCapacity)
        {
        }

        public override void Refuel(double fuealAmount)
        {
            base.Refuel(fuealAmount * FuelLossFactor);
        }
    }
}