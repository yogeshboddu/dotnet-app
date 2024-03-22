using CalculatorApp;
using Xunit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            Assert.Equal(6, _calculator.Add(2, 4));
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calculator.Subtract(5, 3));
        }


        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            Assert.Equal(16, _calculator.Multiply(3, 5));
        }

        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calculator.Divide(10, 5));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
        }
        [Fact]
        public void GetReminder()
        {
            Assert.Equal(0, _calculator.Reminder(10, 5));
        }
    }
}
