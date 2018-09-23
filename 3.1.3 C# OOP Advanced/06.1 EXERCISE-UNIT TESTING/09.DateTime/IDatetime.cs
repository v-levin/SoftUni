﻿using System;

namespace DateTimeNowAddDays
{
    public interface IDateTime
    {
        DateTime Now();

        void AddDays(DateTime date, double daysToAdd);

        TimeSpan SubstractDays(DateTime date, int daysToSybstract);
    }
}
