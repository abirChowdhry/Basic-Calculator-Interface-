using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorInterface
{
    interface IBasicCalculator
    {
        void Addition(double a, double b);
        void Substraction(double c, double d);
        void Multiplication(double e, double f);
        void Division(double g, double h);

    }

    class BasicCalculator
    {
        public void Addition(double a, double b) 
        {
            double result = a + b;
            Console.WriteLine("Addition = "+ result);
        } 
        
        public void Substraction(double a, double b) 
        {
            double result = a - b;
            Console.WriteLine("Substraction = "+ result);
        }
        public void Multiplication(double a, double b) 
        {
            double result = a * b;
            Console.WriteLine("Multiplication = "+ result);
        } 
        public double Division(double a, double b) 
        {
            double result=0;

            if (b == 0)
            {
                Console.WriteLine("Can't Be Divided By 0");
            }
            else
            {
                result = a / b;
            }
            return result;
        }
    }
}
