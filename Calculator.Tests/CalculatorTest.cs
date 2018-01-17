using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add()
        {
            // Given this input to the method
            double sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83.00);
        }
        [Fact]
        public void Subtract()
        {
            double difference = _calculator.Subtract(54, 29);
            Assert.Equal(difference, 25.00);
        }

        [Fact]
        public void Multiply()
        {
            double product = _calculator.Multiply(2.0, 1.5);
            Assert.Equal(product, 3.00);
        }

        [Fact]
        public void Divide()
        {
            double quotient = _calculator.Divide(3, 2);
            Assert.Equal(quotient, 1.5);
        }
    }
}