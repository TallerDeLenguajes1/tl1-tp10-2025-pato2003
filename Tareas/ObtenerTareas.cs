namespace obtenerTareas
{
    using System.Text.Json;
    using tarea;
    public class ObtenerTareas
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Tarea>> GetTareas()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Tarea> listaTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
            return listaTareas;
        }
    }
}