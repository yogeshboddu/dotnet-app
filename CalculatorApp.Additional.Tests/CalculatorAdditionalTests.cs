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
        public void Test_GetGoogleAsync()
        {
            // Arrange
            var response = _calculator.GetGoogleAsync().Result;

            // Act
            var content = response.Content.ReadAsStringAsync().Result;

            // Assert
            Assert.NotEmpty(content);
        }
    }
}
