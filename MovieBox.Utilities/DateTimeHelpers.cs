#region Includes

// .NET Libraries
using System;

#endregion

namespace Utilities
{
    /// <summary>
    /// Represents helper methods to work with dates and times.
    /// </summary>
    public static class DateTimeHelpers
    {
        #region Methods

        /// <summary>
        /// Returns a standard DateTime formatted value from an ISO 8601 DateTime format.
        /// </summary>
        /// <param name="iso8601val">The ISO 8601 datetime as a string.</param>
        /// <returns>A standard .NET DateTime value.</returns>
        public static DateTime ParseToDateTime(string iso8601val)
        {
            return DateTime.Parse(iso8601val, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        /// <summary>
        /// Converts a string to an ISO 8601 formatted DateTimeOffset.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="format">An optional parameter to specify the format.</param>
        /// <returns>A DateTimeOffset object for the value passed in if conversion succeeds, else a new DateTimeOffset.</returns>
        public static DateTimeOffset ParseToIso8601(string value, string format = "")
        {
            DateTimeOffset result;

            if (string.IsNullOrEmpty(format))
                format = "yyyy-MM-ddTHH:mm:ss.fffZ";

            if (DateTimeOffset.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.AssumeLocal, out result))
                return result;

            return new DateTimeOffset();
        }

        /// <summary>
        /// Converts a DateTime to ISO 8601 format.
        /// </summary>
        /// <param name="value">The DateTime to convert.</param>
        /// <returns>A date and time string in ISO 8601 format.</returns>
        public static string FormatToIso8601(DateTime value)
        {
            string result = string.Empty;
            DateTime dt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
            result = FormatToIso8601(DateTimeOffset.Parse(dt.ToString()));
            return result;
        }

        /// <summary>
        /// Converts a DateTimeOffset to ISO 8601 format.
        /// </summary>
        /// <param name="value">The DateTimeOffset to convert.</param>
        /// <returns>A date and time string in ISO 8601 format.</returns>
        public static string FormatToIso8601(DateTimeOffset value)
        {
            string result = string.Empty;
            string format = value.Offset == TimeSpan.Zero ? "yyyy-MM-ddTHH:mm:ss.fffZ" : "yyyy-MM-ddTHH:mm:ss.fffzzz";
            return value.ToString(format);
        }

        /// <summary>
        /// Converts Unix-based time to .NET DateTime format.
        /// </summary>
        /// <param name="unixTime">Unix date/time string.</param>
        /// <returns>A <see cref="System.DateTime"/> value.</returns>
        public static DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        /// <summary>
        /// Gets the beginning of the day for a particular date.
        /// </summary>
        /// <param name="dateString">The date to get start of day for.</param>
        /// <returns>String representing the start of day for a particular date.</returns>
        public static string GetStartOfDay(string dateString)
        {
            string result = DatePartOnly(dateString);
            return $"{result} 12:00:00 AM";
        }

        /// <summary>
        /// Gets the end of day based based on date passed in.
        /// </summary>
        /// <param name="dateString">Date to get the end of day for.</param>
        /// <returns>The date passed in with the end of day timestamp as a string.</returns>
        public static string GetEndOfDay(string dateString)
        {
            string result = DatePartOnly(dateString);
            if (string.IsNullOrEmpty(result))
                return string.Empty;

            return $"{result} 11:59:59 PM";
        }

        /// <summary>
        /// Gets the start of a particular month.
        /// </summary>
        /// <param name="dateString">Date string to get the first of for.</param>
        /// <returns>The date passed in with the day set to the first.</returns>
        public static string GetStartOfMonth(string dateString)
        {
            string result = string.Empty;
            DateTime outResult = new DateTime();
            if (IsValidDateString(dateString, out outResult))
                result = $"{outResult.Month}/01/{outResult.Year}";
            return result;
        }

        public static string GetPreviousStartOfMonth(string dateString = "")
        {
            if (!string.IsNullOrEmpty(dateString))
            {
                DateTime outResult;
                if (IsValidDateString(dateString, out outResult))
                    return $"{outResult.AddMonths(-1).Month}/01/{outResult.AddMonths(-1).Year}";
            }

            return $"{DateTime.Now.AddMonths(-1).Month}/01/{DateTime.Now.AddMonths(-1).Year}";
        }

        public static string GetEndOfMonth(string dateString)
        {
            string result = string.Empty;
            DateTime outResult;
            if (IsValidDateString(dateString, out outResult))
            {
                result = $"{outResult.Month}/01/{outResult.Year}";
                DateTime dtToConvert = DateTime.Parse(result).AddMonths(1);
                result = GetEndOfDay(FormatDate(dtToConvert.AddDays(-1)));
            }
            return result;
        }

        public static string GetPreviousEndOfMonth(string dateString = "")
        {
            if (!string.IsNullOrEmpty(dateString))
            {
                DateTime outResult;
                if (IsValidDateString(dateString, out outResult))
                    return $"{outResult.AddMonths(-1).Month}/01/{outResult.AddMonths(-1).Year}";
            }
            return $"{DateTime.Now.AddMonths(-1).Month}/01/{DateTime.Now.AddMonths(-1).Year}";
        }

        public static string GetStartOfPreviousWeek()
        {
            DateTime result = DateTime.Now.AddDays(((double)(DateTime.Now.DayOfWeek - 6) * -1));
            return result.ToShortDateString();
        }

        public static string GetEndOfPreviousWeek()
        {
            DateTime result = DateTime.Now.AddDays(-1 * ((double)DateTime.Now.DayOfWeek));
            return result.ToShortDateString();
        }

        public static string GetMonth(int day)
        {
            string result = string.Empty;
            switch (day)
            {
                case 1: result = "January"; break;
                case 2: result = "February"; break;
                case 3: result = "March"; break;
                case 4: result = "April"; break;
                case 5: result = "May"; break;
                case 6: result = "June"; break;
                case 7: result = "July"; break;
                case 8: result = "August"; break;
                case 9: result = "September"; break;
                case 10: result = "October"; break;
                case 11: result = "November"; break;
                case 12: result = "December"; break;
                default: result = "None"; break;
            }
            return result;
        }

        public static int GetQuarter(string dateString = "")
        {
            if (!string.IsNullOrEmpty(dateString))
            {
                DateTime outResult;
                return IsValidDateString(dateString, out outResult)
                    ? outResult.Month - 1 / 3 + 1
                    : 0;

            }
            return DateTime.Now.Month - 1 / 3 + 1;
        }

        public static string DatePartOnly(string dateString)
        {
            string result = string.Empty;
            DateTime date = new DateTime();
            bool isValidDate = IsValidDateString(dateString, out date);
            return date.ToString("MM/dd/yyyy");
        }

        public static bool IsValidDateString(string dateString, out DateTime result)
        {
            result = DateTime.MinValue;
            if (string.IsNullOrEmpty(dateString))
                return false;

            if (dateString.Length == 0)
                return true;

            if (DateTime.TryParse(dateString, out result))
                return true;

            return false;
        }

        public static string FormatDate(DateTime date, bool doTime = false)
        {
            if (doTime)
                return date.ToString("MM/dd/yyyy hh:mm:ss tt");

            return date.ToString("MM/dd/yyyy");
        }

        public static bool IsTimeBetween(string currenttime, TimeSpan start, TimeSpan end)
        {
            DateTime curtime = Convert.ToDateTime(currenttime);

            if (end == start)
                return true;
            else if (end < start)
                return curtime.TimeOfDay <= end || curtime.TimeOfDay >= start;
            else
                return curtime.TimeOfDay >= start && curtime.TimeOfDay <= end;
        }

        #endregion
    }
}
