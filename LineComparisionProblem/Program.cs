using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    class Program
    {
        //Declaring Variable
        private static int x1, x2, y1, y2, x3, y3, x4, y4;
        private static double firstLength, secLength;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Computation Program.");
            
            //Getting the length of two lines to check the equality of lines(UC1 & UC2)
            Console.Write("Enter the values of x1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());           
            Console.Write("Enter the values of y1 : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the values of x2 : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the values of y2 : ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the values of x3 : ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the values of y3 : ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the values of x4 : ");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the values of y4 : ");
            y4 = Convert.ToInt32(Console.ReadLine());

            firstLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("First Length is : "+Math.Round(firstLength, 2));
            secLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Second Length is : " + Math.Round(secLength, 2));

            if (firstLength.Equals(secLength))
                Console.WriteLine("The length of the line is equal");
            else
                Console.WriteLine("The length of the line is not equal");
                Console.ReadLine();
        }
    }
}
