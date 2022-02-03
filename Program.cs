using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //Array
            int[] intArr = { 10, 60, 50, 40 };
            double[] doubleArr = { 40.8, 64.3, 39.79, 78.8 };
            string[] stringArr = { "Rajiv", "Raj", "Rahul" };

            /* Creating object of FindMaxValue Class passing array to the Constructor       
             * Calling PrintMaxValue Method to get Max value.
             */
            FindMaxValue<int> findMaxValue = new FindMaxValue<int>(intArr);
            findMaxValue.PrintMaxValue();
            FindMaxValue<double> findMaxValue2 = new FindMaxValue<double>(doubleArr);
            findMaxValue2.PrintMaxValue();
            FindMaxValue<string> findMaxValue3 = new FindMaxValue<string>(stringArr);
            findMaxValue3.PrintMaxValue();
            Console.ReadLine();
              
        }
    }
}
            
