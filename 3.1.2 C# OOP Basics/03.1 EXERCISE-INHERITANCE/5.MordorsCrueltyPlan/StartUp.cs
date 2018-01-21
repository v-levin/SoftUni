﻿using MordorsCrueltyPlan.Factories;
using MordorsCrueltyPlan.Models;
using System;

namespace MordorsCrueltyPlan
{
    public class StartUp
    {
        public static void Main()
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var gandalf = new Gandalf();

            var inputFood = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var foodStr in inputFood)
            {
                Food food = foodFactory.GetFood(foodStr);
                gandalf.Eat(food);
            }

            int totalHapinessPoints = gandalf.GetHapinessPoints();
            Mood currentMood = moodFactory.GetMood(totalHapinessPoints);

            Console.WriteLine(totalHapinessPoints);
            Console.WriteLine(currentMood);
        }
    }
}
