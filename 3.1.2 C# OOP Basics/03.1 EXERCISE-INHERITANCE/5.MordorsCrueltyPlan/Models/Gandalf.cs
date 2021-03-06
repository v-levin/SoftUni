﻿using System.Collections.Generic;
using System.Linq;

namespace MordorsCrueltyPlan.Models
{
    public class Gandalf
    {
        private List<Food> foodEaten;

        public Gandalf()
        {
            this.foodEaten = new List<Food>();
        }

        public void Eat(Food food)
        {
            this.foodEaten.Add(food);
        }

        public int GetHapinessPoints()
        {
            return foodEaten.Sum(f => f.GetHapinessPoints());
        }
    }
}
