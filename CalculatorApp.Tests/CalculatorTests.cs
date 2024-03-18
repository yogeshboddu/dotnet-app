using CalculatorApp;
using Xunit;

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
            Assert.Equal(15, _calculator.Multiply(3, 5));
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
        public void getReminder()
        {
            Assert.Equal(0, _calculator.Reminder(10, 5));
        }
    }
}
