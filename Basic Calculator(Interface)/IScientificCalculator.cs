using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorInterface
{
    interface IScientificCalculator
    {
        void ToBinary(double x);
        void XtoY(double x, double y);
    }

    class ScientificCalculator 
    {
        public void XtoY(double x, double y) 
        {
            for (int i = 1; i < y; i++) 
            {
              x = x * x; 
            }

            Console.WriteLine("X to the Power Y = " + x);
        }

        public void ToBinary(int x)
        {
            BasicCalculator bc = new BasicCalculator();
            int i,j;
            int[] a = new int[10];
            int[] b = { };

            for ( i = 0; x > 0; i++)
            {
                a[i] = x % 2;
                x = (int) bc.Division(x, 2);
            }

            Console.WriteLine("Binary: [");

            for ( i -= 1; i >= 0; i--) 
            {
                for (j = i; j >= 0; j--)
                {
                    b[j] = a[i];
                }
            }

            Console.WriteLine(b);
        }
    }
}
