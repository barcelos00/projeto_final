using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();

        string url = "http://localhost:5143/api/produtos";

        try
        {
            HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string resultado = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Resposta da API:");
            Console.WriteLine(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao consumir API: " + ex.Message);
        }
    }
}