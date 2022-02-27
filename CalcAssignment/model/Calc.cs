using System;
using System.Collections.Generic;
using System.Text;

namespace CalcAssignment.model
{
    public  class Calc
    {
      
             
        public static double Multiple (double num1 , double num2)
        {
         double multiple= num1 * num2;
            return multiple;
        }
        public double Division(double  num1,double  num2)
        {
            double division = num1 / num2;

            if (num2 == 0)
            {
                throw new DivideByZeroException ("The second number can not be Zero");

            }
            return division;
        }
        public double Addition(double [] numArray)
        {
            double sum = 0;
            for (int i = 0; i < numArray .Length ; i++)
            {
                sum = sum + numArray[i];

            }
            return sum;
        }
        public double substract(double[] numArray)
        {
            double minus = numArray [0];
            for (int i = 1; i < numArray.Length; i++)
            {
                minus = minus- (numArray[i]);

            }
            return minus;
        }






    }
}
