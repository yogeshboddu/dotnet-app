using System;
using System.Net.Http;
using System.Threading.Tasks;
using CalculatorApp;

class Program
{
    static HttpClient client = new HttpClient();

    static async Task Main()
    {
        var response = await GetGoogleAsync();
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }

    static async Task<HttpResponseMessage> GetGoogleAsync()
    {
        return await client.GetAsync("http://localhost:8080");
    }
}
