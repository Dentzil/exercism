﻿using System;

namespace Exercism_leap
{
    public static class Year
    {
        public static bool IsLeap(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }

            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            // Or just use System.DateTime.IsLeapYear(...)
        }
    }
}
