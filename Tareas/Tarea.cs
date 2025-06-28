
using System.Text.Json.Serialization;

namespace tarea
{
    public class Tarea
    {
        [JsonPropertyName("userId")]
        public int IdUsuario{ get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Titulo { get; set; }

        [JsonPropertyName("completed")]
        public bool Completada { get; set; }
    }
}