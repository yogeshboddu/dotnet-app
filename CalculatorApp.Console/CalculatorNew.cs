using System;
using System.Net.Http.Headers;
using System.Text;

namespace CalculatorApp
{
    public class CalculatorNew
    {
        static HttpClient client = new HttpClient();

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Subtract1(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.", nameof(b));
            }
            return a / b;
        }
        public int Reminder(int a, int b)
        {
            return a % b;
        }

    public async Task<HttpResponseMessage> GetGoogleAsync()
    {

        // Make the GET request
        return await client.GetAsync("https://www.google.com");
    }
    }
}
