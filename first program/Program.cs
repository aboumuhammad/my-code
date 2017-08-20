using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_floatpointeType
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dcmin = decimal.MinValue;
            decimal dcmax = decimal.MaxValue;
          
            Console.WriteLine("min value = {0}\n max value = {1}", dcmin, dcmax);
            Console.ReadKey();
         
        }
    }
}
