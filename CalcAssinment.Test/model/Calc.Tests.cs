using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CalcAssignment.model;
using CalcAssignment;


namespace CalcAssinment.Test.model
{
   public  class CalcTests
    {
        [Fact]
        public void MultipleTest()
        {
            //Arrang
            double num1 = 0.3;
            double num2 = 0.8;

            //Act

            double result = Calc.Multiple(num1, num2);

            //Assert

            Assert.Equal(0.24, result,2);
        }



        [Fact]
        public void DivisionTest()
        {
            //Arrang
            double num1 =8.0;
            double num2 =0.2;

            //Act
            Calc calc = new Calc();
            double result = calc.Division (num1, num2);

            //Assert

            Assert.Equal(40, result,2);
        }



        [Theory]
        [InlineData(0)]
        public void DivideByZeroExceptionTest(double  number2)
        {
            //Arrange
           double number1 = 9;


            //Act
            Calc calc = new Calc();

            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Division(number1, number2));
        }



        [Fact]
        public void AdditionTest()
        {
            //Arrang
            double[] numberArray = new double[2] { -6.9, 7.7 };
            //Act
            Calc calc = new Calc();
            double result = calc.Addition (numberArray );

            //Assert

            Assert.Equal(0.8, result,2);
        }


        [Fact]
        public void SubstractTest()
        {
            //Arrang
            double[] numberArray = new double[2] { -6.9, 7.7 };
            //Act
            Calc calc = new Calc();
            double result = calc.substract(numberArray);

            //Assert

            Assert.Equal(-14.6, result, 2);
        }



    }
}
