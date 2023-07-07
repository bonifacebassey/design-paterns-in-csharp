using Fischer.Localization.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fischer.UI.Extensions;

/// <summary>
/// DateTime Extension class that generates an elaspedTime string from a reference DateTime
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// Gets elapsedTime as localized string
    /// </summary>
    /// <param name="referenceDateTime"></param>
    /// <param name="localizer"></param>
    /// <param name="allowSeconds">Whether elapsedTime in seconds is allowed or not</param>
    /// <returns></returns>
    public static string GetElapsedTimeString(this DateTime referenceDateTime, ILocalizer localizer, bool allowSeconds=true)
    {
        if (!Validate(referenceDateTime))
            return "";

        return GetElapsedTime(referenceDateTime, localizer, allowSeconds);
    }

    private static bool Validate(DateTime referenceDateTime)
    {
        return DateTime.Now >= referenceDateTime;
    }

    private static string GetElapsedTime(DateTime referenceDateTime, ILocalizer localizer, bool allowSeconds)
    {
        var daysOfMonth = new List<int>() { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        daysOfMonth[daysOfMonth.IndexOf(-1)] = DateTime.IsLeapYear(DateTime.Now.Year) ? 29 : 28;

        var timeSpan = DateTime.Now - referenceDateTime;
        var days = timeSpan.Days;
        var hours = timeSpan.Hours;
        var minutes = timeSpan.Minutes;
        var seconds = timeSpan.Seconds;

        // Calculate years
        DateTime zeroTime = new DateTime(1, 1, 1);      // start at year 1
        int years = zeroTime.Add(timeSpan).Year - 1;    // remove the start year

        var startYear = DateTime.Now.Year - years;
        for (int i = 0; i < years; ++i) {
            days -= DateTime.IsLeapYear(startYear) ? 366 : 365;
            startYear++;
        }

        // Calculate months
        var months = 12 * (DateTime.Now.Year - referenceDateTime.Year) + (DateTime.Now.Month - referenceDateTime.Month);
        if (DateTime.Now.CompareTo(referenceDateTime.AddMonths(months).AddMilliseconds(-500)) <= 0)
            --months;
        months -= 12 * years;

        var startMonth = referenceDateTime.Month;
        for (int i = 0; i < months; ++i) {
            days -= daysOfMonth.ElementAtOrDefault(startMonth);
            startMonth++;
            if (startMonth >= 12)
                startMonth = 1;
        }

        // Calculate weeks
        var weeks = days / 7;

        // Calculate days
        if (weeks > 0)
            days %= 7;


        string key = "ElapsedTime_";
        object value;
        do {
            // Elapsed Years
            if (years > 0) {
                key += years > 1 ? "Years" : "Year";
                value = years;
                break;
            }

            // Elapsed Months
            if (months > 0) {
                key += months > 1 ? "Months" : "Month";
                value = months;
                break;
            }

            // Elapsed Weeks
            if (weeks > 0) {
                key += weeks > 1 ? "Weeks" : "Week";
                value = weeks;
                break;
            }

            // Elapsed Days
            if (days > 0) {
                key += days > 1 ? "Days" : "Day";
                value = days;
                break;
            }

            // Elapsed Hours
            if (hours > 0) {
                if (DateTime.Now.Date == referenceDateTime.Date) {
                    key += hours > 1 ? "Hours" : "Hour";
                    value = hours;
                }
                else {
                    key += "Yesterday";
                    value = referenceDateTime.ToShortTimeString();
                }
                break;
            }

            // Elapsed Minutes
            if (minutes > 0) {
                key += minutes > 1 ? "Minutes" : "Minute";
                value = minutes;
                break;
            }

            // Elapsed Seconds
            if (allowSeconds && seconds > 0) {
                key += seconds > 1 ? "Seconds" : "Second";
                value = seconds;
                break;
            }

            // Just Now
            key += "Just_now";
            value = "";

        } while (false);

        localizer.SetRoot(typeof(DateTimeExtensions));
        return (localizer != null) ? localizer[$"{key}", $"{value}"] : $"{key}";
    }
}
