using System;

namespace SharpExtensions
{
    public static class IntegerDateTimeExtensions
    {
        public static TimeSpan Days(this int number)
        {
            return TimeSpan.FromDays(number);
        }

        public static TimeSpan Hours(this int number)
        {
            return TimeSpan.FromHours(number);
        }

        public static TimeSpan Milliseconds(this int number)
        {
            return TimeSpan.FromMilliseconds(number);
        }

        public static TimeSpan Minutes(this int number)
        {
            return TimeSpan.FromMinutes(number);
        }

        public static TimeSpan Seconds(this int number)
        {
            return TimeSpan.FromSeconds(number);
        }

        public static TimeSpan Ticks(this int number)
        {
            return TimeSpan.FromTicks(number);
        }
    }
}
