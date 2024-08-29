using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLesson
{
    public static class Extensions
    {
        public static string Capitalize(this string str)
        {
            if (str == null)
                return null;

            if (str == string.Empty)
                return str;

            var c = char.ToUpper(str[0]);
            if (str.Length > 1)
                return c + str.Substring(1);
            Random rnd = new Random();
            return c.ToString();
        }

        public static double NextDouble(this Random rnd, int i)
        {
            
            return rnd.NextDouble() * i;
        }

        public static bool CoinFlip(this Random rnd)
        {
            return (rnd.NextDouble(2) < 1);
        }
        public static bool CoinFlip(this Random rnd, double dbl)
        {
            if (dbl > 1)
                dbl = 1;
            else if (dbl < 0)
                dbl = 0;
            return (rnd.NextDouble(1) < 1 - dbl);
        }

        public static string NextString(this Random rnd, string[] str)
        {
            string selected = string.Empty;
            if (str.Any())
            {
                selected = str[rnd.Next(str.Length)];
            }
            return selected;
        }
    }
}
