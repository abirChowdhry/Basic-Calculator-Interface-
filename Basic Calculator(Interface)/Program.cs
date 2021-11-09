using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator bc = new BasicCalculator();

            bc.Addition(1,2);
            bc.Multiplication(1,2);
            Console.WriteLine("Division = " +bc.Division(1,0));//for testing somthing divided by 0
            //bc.Division(1,2);//perfect form of division
            bc.Substraction(1,2);

            ScientificCalculator sc = new ScientificCalculator();

            Console.WriteLine();
            Console.WriteLine("Enter Base Number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Power: ");
            double y = Convert.ToDouble(Console.ReadLine());

            sc.XtoY(x, y);

            Console.WriteLine();
            Console.WriteLine("Enter Any Integer Number To Convert into Binary: ");
            int z = Convert.ToInt32(Console.ReadLine());

            sc.ToBinary(z);
        }
    }
}
