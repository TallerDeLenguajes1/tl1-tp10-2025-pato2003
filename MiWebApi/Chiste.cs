using System.Text.Json.Serialization;

namespace chiste
{
    public class Respuesta
    {
        [JsonPropertyName("error")]
        public bool Error { get; set; }
        [JsonPropertyName("amount")]
        public int Cantidad{ get; set; }
        [JsonPropertyName("jokes")]
        public List<Chiste> Chistes{ get; set; }

    }
    public class Chiste
    {
        [JsonPropertyName("category")]
        public string Categoria { get; set; }
        [JsonPropertyName("type")]
        public string Tipo { get; set; }
        [JsonPropertyName("joke")]
        public string Contenido { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}