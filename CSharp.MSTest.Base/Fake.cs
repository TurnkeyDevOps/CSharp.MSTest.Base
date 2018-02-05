using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp.MSTest.Base
{
    public static class Fake
    {
        private static readonly Random _random = new Random();

        public static string ZipCode()
        {
            return _random.Next(10000, 99999).ToString();
        }

        public static string StateAbbreviation()
        {
            string[] states = CSharp.MSTest.Base.Properties.Resources.USStateAbbreviations.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return states[_random.Next(0, states.Length - 1)];
        }

        public static string SSN()
        {
            return string.Format("{0}{1}{2}",
                _random.Next(1, 665).ToString().PadLeft(3, '0'),
                _random.Next(1, 99).ToString().PadLeft(2, '0'),
                _random.Next(1, 9999).ToString().PadLeft(4, '0'));
        }

        /// <summary>
        /// Birth Date between 21 and 60 years old
        /// </summary>
        /// <returns></returns>
        public static DateTime BirthDate()
        {
            return BirthDate(21, 60);
        }

        public static DateTime BirthDate(int minAge, int maxAge)
        {
            if (minAge > maxAge)
                throw new ArgumentOutOfRangeException("minAge", "minAge cannot be greater than maxAge");

            DateTime startDate = DateTime.Today.AddYears(-maxAge);
            DateTime endDate = DateTime.Today.AddYears(-minAge);

            TimeSpan timeSpan = endDate - startDate;

            TimeSpan newSpan = new TimeSpan(0, _random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return (startDate + newSpan).Date;
        }

        public static double Latitude(double min = -90, double max = 90)
        {
            return Math.Round(Double(min, max), 4);
        }

        public static double Longitude(double min = -180, double max = 180)
        {
            return Math.Round(Double(min, max), 4);
        }

        public static string FullName()
        {
            return String.Format("{0} {1}. {2}", FirstName(), MiddleInitial(), LastName());
        }

        public static string MiddleInitial()
        {
            return FirstName()[0].ToString();
        }

        public static string MiddleName()
        {
            return FirstName();
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

        public static string address()
        {
            var reader = new StreamReader(File.OpenRead(@"Addresses.txt"));
            List<string> listRows = new List<string>();
            while (!reader.EndOfStream)
            {
                listRows.Add(reader.ReadLine());
            }
            int index = _random.Next(listRows.Count);
            string random_address = listRows[ index ];
            return random_address;
        }
    }
}
