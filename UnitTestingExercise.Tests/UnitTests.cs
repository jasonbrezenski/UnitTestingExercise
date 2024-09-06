using System;
using System.Runtime.InteropServices;
using NuGet.Frameworks;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 5, 7, 15)]
        [InlineData(1, 0, -1, 0)]
        [InlineData(5, -6, -5, -6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            
            var calculator = new Calculator();
            
            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(10, 7, 3)]
        [InlineData(3,3, 0)]
        [InlineData(2, 4, -2)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var calculator = new Calculator();
            
            //Act

            var actual = calculator.Subtract(minuend, subtrahend);

            //Assert
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 100)]//Add test data <-------
        [InlineData(7, 5, 35)]
        [InlineData(0, 2, 0)]
        [InlineData(-3, 4, -12)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calculator = new Calculator();
            
            //Act

            var actual = calculator.Multiply(num1, num2);
            
            //Assert
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 4, 3)]//Add test data <-------
        [InlineData(20, 4, 5)]
        [InlineData(0, 3, 0)]
        [InlineData(15, -3, -5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calculator = new Calculator();
            
            //Act

            var actual = calculator.Divide(num1, num2);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
