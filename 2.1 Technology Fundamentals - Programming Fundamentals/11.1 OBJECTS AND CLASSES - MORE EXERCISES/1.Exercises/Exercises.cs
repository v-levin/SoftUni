using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }

        public static Exercise Parse(string inputLine)
        {
            var inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var topic = inputParams[0];
            var courseName = inputParams[1];
            var judgeContestLink = inputParams[2];
            var problems = inputParams.Skip(3).ToList();

            return new Exercise
            {
                Topic = topic,
                CourseName = courseName,
                JudgeContestLink = judgeContestLink,
                Problems = new List<string>(problems)
            };
        }
    }

    public class Exercises
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (inputLine != "go go go")
            {
                var newExercise = new Exercise();

                newExercise = Exercise.Parse(inputLine);

                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                for (int i = 0; i < exercise.Problems.Count; i++)
                {
                    var index = i + 1;
                    var problem = exercise.Problems[i];

                    Console.WriteLine($"{index}. {problem}");
                }
            }
        }
    }
}
