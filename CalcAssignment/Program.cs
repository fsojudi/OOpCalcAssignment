using CalcAssignment.model;
using System;

namespace CalcAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            double [] arraynumber= calc . numArray= new double [5]{ +1.1, - 3.3, + 5, + 7, + 8.8};
            Console.Write("please input number1: ");
             double number1 =Input(calc.num1);
            Console.Write("\r\n");

            Console.Write("please input number2: ");
            double number2 = Input(calc.num2);
            Console.WriteLine($"{number1 } * {number2 }= {calc.Multiple(number1, number2)}");
            Console.WriteLine($"{number1 } / {number2 }= {calc.Division (number1, number2)}");
            Console.Write("\r\n");
            Console.WriteLine(" The addition of arrays{ +1.1, - 3.3, + 5, + 7, + 8.8} is:");
            foreach (double  number in arraynumber )
            {
                Console.Write($"+({number}) ");
            }
            Console.WriteLine($"= {calc.Addition(calc.numArray)}");
            Console.Write("\r\n");
            Console.WriteLine(" The substract of arrays{ +1.1, - 3.3, + 5, + 7, + 8.8} is:");
            foreach (double number in arraynumber)
            {
                Console.Write($"-({number}) ");
            }
            Console.WriteLine($"= {calc.substract (calc.numArray)}");


        }

        static double Input(double number)
        {
            try
            {
                number = double.Parse(Console.ReadLine());
            }
            catch(Exception )
            {
                throw new IndexOutOfRangeException(" The input must be a number");

            }
            
            return number;
        }
        
    }

}
