using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.services
{
    public class CalculationServices
    {
        public static void ShowMax(double x,double y) { 
        
            double max = x > y ? x : y;
            Console.WriteLine($"Max is {max}");
        }
        public static void ShowMin(double x, double y)
        {
            double min = x < y ? x : y;
            Console.WriteLine($"Min is {min}");
        }
        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
