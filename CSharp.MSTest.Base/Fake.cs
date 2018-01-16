using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.MSTest.Base
{
    public static class Fake
    {
        private static readonly Random _random = new Random();

        public static double Latitude(double min = -90, double max = 90)
        {
            return Math.Round(Double(min, max), 4);
        }

        public static double Longitude(double min = -180, double max = 180)
        {
            return Math.Round(Double(min, max), 4);
        }

        public static string FirstName()
        {
            string[] firstNames = CSharp.MSTest.Base.Properties.Resources.FirstNames.Split(new char[] {'\r', '\n'},StringSplitOptions.RemoveEmptyEntries);

            return firstNames[_random.Next(0, firstNames.Length - 1)];
        }

        public static string LastName()
        {
            string[] lastNames = CSharp.MSTest.Base.Properties.Resources.LastNames.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return textInfo.ToTitleCase(lastNames[_random.Next(0, lastNames.Length - 1)].ToLower());
        }

        public static decimal AmountDecimal()
        {
            return _random.Next(1, 999) + .99M;
        }

        public static decimal PercentDecimal()
        {
            return _random.Next(1, 99) / 100M;
        }

        public static double Double(double min = 0.0d, double max = 1.0d)
        {
            if (min == 0.0d && max == 1.0d)
            {
                return _random.NextDouble();
            }

            return _random.NextDouble() * (max - min) + min;
        }
    }
}
