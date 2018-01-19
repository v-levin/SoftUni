using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            var songs = new List<Song>();

            var songsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsCount; i++)
            {
                var songInfo = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var artistName = songInfo[0];
                    var songName = songInfo[1];

                    var songDurationInfo = songInfo[2].Split(':');
                    int minutes;
                    int seconds;

                    if (int.TryParse(songDurationInfo[0], out minutes) && int.TryParse(songDurationInfo[1], out seconds))
                    {
                        var song = new Song(artistName, songName, minutes, seconds);
                        songs.Add(song);

                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");

            var totalDurationInSeconds = songs.Sum(s => s.Minutes * 60 + s.Seconds);

            var totalHours = totalDurationInSeconds / 60 / 60;
            var totalMinutes = (totalDurationInSeconds / 60) - (totalHours * 60);
            var totalSeconds = totalDurationInSeconds % 60;

            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}
