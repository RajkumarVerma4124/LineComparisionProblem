using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class CompareLine
    {
        //Method to Compare the two lines using compareTo(UC3 & UC4)
        public static void CheckLines(double firstLength, double secLength)
        {
            //Comparing the two lines using compare(UC3)
            int diffLength = firstLength.CompareTo(secLength);
            Console.Write("\nUsing CompareTo Method :- ");
            if (diffLength == 0)
                Console.Write("Lines are equal in length");
            else if (diffLength > 0)
                Console.Write("First line is greater in length compare to second line");
            else
                Console.Write("First line is smaller in length compare to second line");
            Console.ReadLine();
        }
    }
}
