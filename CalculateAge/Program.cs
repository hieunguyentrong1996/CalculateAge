using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = CalculateAges(DateTime.Now, DateTime.Now.AddYears(89));
        }

        public static int CalculateAges(DateTime start, DateTime end)
        {
            int age = end.Year - start.Year;
            if (start > end.AddYears(-age))
                age--;
            return age;
        }
    }
}
