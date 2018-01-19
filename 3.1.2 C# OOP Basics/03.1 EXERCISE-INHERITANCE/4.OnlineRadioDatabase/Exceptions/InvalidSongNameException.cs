﻿namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 30;

        public override string Message => $"Song name should be between {MinNameLength} and {MaxNameLength} symbols.";
    }
}
