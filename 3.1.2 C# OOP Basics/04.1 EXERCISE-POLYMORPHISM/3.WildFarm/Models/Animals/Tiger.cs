﻿using System;

namespace WildFarm.Models.Animals
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double AnimalWeight, string livingRegion) 
            : base(animalName, animalType, AnimalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }

            base.Eat(food);
        }
    }
}
