using System;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {
        public double CalculateDifference(string date1, string date2)
        {
            var d1 = date1.Split().Select(int.Parse).ToArray();
            var d2 = date2.Split().Select(int.Parse).ToArray();

            var firstDate = new DateTime(d1[0], d1[1], d1[2]);
            var secondDate = new DateTime(d2[0], d2[1], d2[2]);

            return Math.Abs((firstDate - secondDate).TotalDays);
        }
    }
}
