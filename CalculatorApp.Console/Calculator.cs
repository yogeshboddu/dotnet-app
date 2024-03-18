using System;
using System.Net.Http.Headers;

namespace CalculatorApp
{
    public class Calculator
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
  client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "asdasdasd13131easdasd13");

        // Make the GET request
        return await client.GetAsync("https://www.google.com");
        }
    }
}
