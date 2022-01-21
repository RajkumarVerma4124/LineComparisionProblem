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
        private static int x1, x2, y1, y2;
        private static double length;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Computation Program.");
            
            //Getting the length of the line(UC1)
            Console.Write("Enter the values of x1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the values of y1 : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the values of x2 : ");
            x2 = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter the values of y2 : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of the line is : " + Math.Round(length,2));
            Console.ReadLine();
        }
    }
}
