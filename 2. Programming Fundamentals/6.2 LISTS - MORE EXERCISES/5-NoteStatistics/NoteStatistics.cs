using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_NoteStatistics
{
    class NoteStatistics
    {
        static void Main()
        {
            var frequencies = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            var noteList = new List<string>(new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });
            var frequencyList = new List<decimal>(new decimal[] { 261.63m, 277.18m, 293.66m, 311.13m, 329.63m, 349.23m, 369.99m, 392.00m, 415.30m, 440.00m, 466.16m, 493.88m });

            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            decimal naturalsSum = 0;
            decimal sharpsSum = 0;

            foreach (var freq in frequencies)
            {
                for (int i = 0; i < noteList.Count; i++)
                {
                    var currentFreq = frequencyList[i];
                    var currentNote = noteList[i];

                    if (freq == currentFreq)
                    {
                        notes.Add(currentNote);

                        if (currentNote.Contains("#"))
                        {
                            sharps.Add(currentNote);
                            sharpsSum += currentFreq;
                        }
                        else
                        {
                            naturals.Add(currentNote);
                            naturalsSum += currentFreq;
                        }

                        break;
                    }

                }
            }

            Console.WriteLine($"Notes: { string.Join(" ", notes) }");
            Console.WriteLine($"Naturals: { string.Join(", ", naturals) }");
            Console.WriteLine($"Sharps: { string.Join(", ", sharps) }");
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
    }
}
