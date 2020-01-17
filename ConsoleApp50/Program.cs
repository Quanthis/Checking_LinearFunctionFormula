using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program checks formula for linear funcion");
            double x1, x2, y1, y2, a, b, y, d;
            Console.WriteLine("x1= ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1= ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2= ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2= ");
            y2 = Convert.ToDouble(Console.ReadLine());
            if ((y2 == y1) && (x2 == x1)) Console.WriteLine("You provided data for same point twice");
            else {
                a = (y2 - y1) / (x2 - x1);
                b = y2-x2;
                Console.WriteLine("Formula of this function: to y={0}*x+{1}",a,b);
                Console.ReadKey();
            }
        }
    }
}
