using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class EqualLine
    {
        //Method To Check the equality of two lines(UC2 & UC4)
        public static void CheckLines(double firstLength, double secLength)
        {
            Console.Write("Using Equals Method :- ");
            if (firstLength.Equals(secLength))
                Console.Write("The length of the line is equal");
            else
                Console.Write("The length of the line is not equal");
            Console.ReadLine();

        }
    }
}
