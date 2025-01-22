using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedNasrAssignment
{
    internal class Duration
    {

        #region Properties

        public int Hours { get; set; }
        public int Minuites { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors

        public Duration()
        {
            
        }
        public Duration(int hours, int miniutes, int seconds)
        {
            Hours = hours;
            Minuites = miniutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds = seconds % 3600;
            Minuites = seconds / 60;
            Seconds = seconds % 60;
        }

        #endregion

        #region Methods

        #region Operators Overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            int secondsD1 = Toeconds(d1.Hours, d1.Minuites, d1.Seconds);
            int secondsD2 = Toeconds(d2.Hours, d2.Minuites, d2.Seconds);

            return new Duration(secondsD1 + secondsD2);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int secondsD1 = Toeconds(d1.Hours, d1.Minuites, d1.Seconds);
            int secondsD2 = Toeconds(d2.Hours, d2.Minuites, d2.Seconds);

            return new Duration(secondsD1 - secondsD2);
        }

        public static Duration operator +(Duration d1, int d2)
        {
            int seconds = Toeconds(d1.Hours, d1.Minuites, d1.Seconds) + d2;

            return new Duration(seconds);

        }

        public static Duration operator +(int d1, Duration d2)
        {
            int seconds = Toeconds(d2.Hours, d2.Minuites, d2.Seconds) + d1;

            return new Duration(seconds);

        }

        public static Duration operator ++(Duration d)
        {
            int hours = d?.Hours ?? 0;
            int miniutes = d?.Minuites ?? 0;
            int seconds = d?.Seconds ?? 0;

            int finalSeconds = Toeconds(hours, miniutes, seconds);

            return new Duration(finalSeconds + 60);

        }

        public static Duration operator --(Duration d)
        {
            int hours = d.Hours;
            int miniutes = d?.Minuites ?? 0;
            int seconds = d.Seconds;

            int finalSeconds = Toeconds(hours, miniutes, seconds);

            return new Duration(finalSeconds - 60);

        }

        public static bool operator >(Duration d1, Duration d2)
        {

            return Toeconds(d1.Hours, d1.Minuites, d1.Seconds) > Toeconds(d2.Hours, d2.Minuites, d2.Seconds);
        }

        public static bool operator <(Duration d1, Duration d2)
        {

            return Toeconds(d1.Hours, d1.Minuites, d1.Seconds) < Toeconds(d2.Hours, d2.Minuites, d2.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {

            return Toeconds(d1.Hours, d1.Minuites, d1.Seconds) <= Toeconds(d2.Hours, d2.Minuites, d2.Seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {

            return Toeconds(d1.Hours, d1.Minuites, d1.Seconds) >= Toeconds(d2.Hours, d2.Minuites, d2.Seconds);
        }

        public static explicit operator bool(Duration d)
        {
            return Toeconds(d.Hours, d.Minuites, d.Seconds) > 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minuites, d.Seconds);
        }  
        #endregion

        public static int Toeconds(int hours, int minuites, int seconds)
        {
            return (hours * 3600) + (minuites * 60) + seconds;
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            if (Hours == 0)
                return $"Minuites: {Minuites}, Second: {Seconds}";
            return $"Hours: {Hours}, Minuites: {Minuites}, Seconds: {Seconds}";
        }
        #endregion

    }
}
