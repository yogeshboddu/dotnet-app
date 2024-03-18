using System;
using System.Net.Http.Headers;
using System.Text;

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
    string username = "admin";
    string password = "myPassword123456";

    // Create a byte array of the username and password
    var byteArray = Encoding.ASCII.GetBytes(username + ":" + password);

    // Convert the byte array to a Base64 string
    var authorization = Convert.ToBase64String(byteArray);

    // Add the Authorization header with the Basic scheme and the Base64 string
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorization);

    // Make the GET request
    return await client.GetAsync("https://www.google.com");
}
    }
}
