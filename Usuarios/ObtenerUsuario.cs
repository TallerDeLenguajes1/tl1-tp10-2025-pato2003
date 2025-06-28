namespace obtenerUsuario
{
    using System.Text.Json;
    using usuario;
    public class ObtenerUsuario
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Usuario>> GetUsuarios()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
            return listaUsuarios;
        }

    }
    
}
