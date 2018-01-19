using System;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}
