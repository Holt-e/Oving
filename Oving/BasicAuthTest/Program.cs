using System.Net.Http.Headers;
using System.Text;

var url = "https://google.com";

var username = "sap";
var password = "2ewqeq";

var client = new HttpClient();
client.BaseAddress = new Uri(url);
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
    Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}")));

var response = await client.GetAsync(url);

Console.WriteLine(response.StatusCode);

