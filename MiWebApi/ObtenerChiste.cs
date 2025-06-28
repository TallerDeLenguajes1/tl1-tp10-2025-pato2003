namespace obtenerChiste
{
    using System.Net.Http;
    using System.Text.Json;
    using chiste;
    public class ObtenerChiste
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Chiste>> GetChistes()
        {
            string url = "https://v2.jokeapi.dev/joke/Any?lang=es&type=single&amount=10";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Chiste> listaChistes = JsonSerializer.Deserialize<Respuesta>(responseBody).Chistes;
            return listaChistes;
        }
    }
}