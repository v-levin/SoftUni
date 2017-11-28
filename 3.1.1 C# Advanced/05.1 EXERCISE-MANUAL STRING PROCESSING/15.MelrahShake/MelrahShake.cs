using System;

namespace _15.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (text.Contains(pattern) && !string.IsNullOrEmpty(pattern))
            {
                var firstIndexOfPattern = text.IndexOf(pattern);
                var lastIndexOfPattern = text.LastIndexOf(pattern);

                // check if found at least TWO matches
                if (firstIndexOfPattern == lastIndexOfPattern)
                {
                    break;
                }

                Console.WriteLine("Shaked it.");

                // remove first and last occurance of pattern
                text = text.Remove(lastIndexOfPattern, pattern.Length).Remove(firstIndexOfPattern, pattern.Length);
                
                var indexToRemove = pattern.Length / 2;
                pattern = pattern.Remove(indexToRemove, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
