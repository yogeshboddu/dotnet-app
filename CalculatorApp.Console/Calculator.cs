using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        static HttpClient client = new HttpClient();

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add1(int a, int b)
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

        // Method with hardcoded credentials
        public void ConnectToDatabase()
        {
            string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            // Simulate database connection using the connection string
            Console.WriteLine("Connecting to database with connection string: " + connectionString);
        }

        // Method with improper SSL verification
        public async Task<string> GetInsecureDataAsync()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true; // Bypasses SSL verification

            using (HttpClient insecureClient = new HttpClient(handler))
            {
                var response = await insecureClient.GetStringAsync("https://example.com");
                return response;
            }
        }

        // Method with inadequate input validation
        public int ParseAndAdd(string a, string b)
        {
            // Potentially dangerous if inputs are not validated
            int num1 = int.Parse(a);
            int num2 = int.Parse(b);
            return num1 + num2;
        }

        public async Task<HttpResponseMessage> GetGoogleAsync()
        {
            // Make the GET request
            return await client.GetAsync("https://www.google.com");
        }
    }
}
