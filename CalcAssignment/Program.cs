using CalcAssignment.model;
using System;

namespace CalcAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
          
        Calc calc = new Calc();

            double [] arraynumber= new double [5]{ +1.1, - 3.3, + 5, + 7, + 8.8};

            Console.Write("please input number1: ");
             double number1 =Input();
            Console.Write("\r\n");

            Console.Write("please input number2: ");
            double number2 = Input();
            
            Console.WriteLine($"{number1 } * {number2 }= {Calc.Multiple(number1, number2)}");
            Console.WriteLine($"{number1 } / {number2 }= {calc.Division (number1, number2)}");
           
            Console.Write("\r\n");
            Console.WriteLine(" The addition of arrays{ +1.1, - 3.3, + 5, + 7, + 8.8} is:");
            foreach (double  number in arraynumber )
            {
                Console.Write($"+({number}) ");
            }
            Console.WriteLine($"= {calc.Addition(arraynumber )}");
           
            Console.Write("\r\n");
            Console.WriteLine(" The substract of arrays{ +1.1, - 3.3, + 5, + 7, + 8.8} is:");
            Console.Write(arraynumber [0]);
            for (int i = 1; i <arraynumber .Length; i++)
            {
                Console.Write($"-({arraynumber [i]}) ");
            }
            
            Console.WriteLine($"= {calc.substract (arraynumber )}");


        }

        static double Input()
        {
            try
            {
                double  number = double.Parse(Console.ReadLine());
                return number;
            }
            catch(Exception )
            {
                throw new IndexOutOfRangeException(" The input must be a number");

            }
            
            
        }
        
    }

}
