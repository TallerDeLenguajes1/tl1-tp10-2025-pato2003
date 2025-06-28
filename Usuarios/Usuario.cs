using System.Text.Json.Serialization;

namespace usuario
{
    public class Usuario
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Nombre { get; set; }
        [JsonPropertyName("email")]
        public string Mail { get; set; }
        [JsonPropertyName("address")]
        public Direccion Direc { get; set; }
        [JsonPropertyName("phone")]
        public string Telefono { get; set; }
        [JsonPropertyName("website")]
        public string SitioWeb { get; set; }
        [JsonPropertyName("company")]
        public Compania Compania { get; set; }

    }
    public class Direccion
    {
        [JsonPropertyName("street")]
        public string Calle { get; set; }
        [JsonPropertyName("suite")]
        public string Numero { get; set; }
        [JsonPropertyName("city")]
        public string Ciudad { get; set; }
        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }
        [JsonPropertyName("geo")]
        public Localizacion Local { get; set; }

    }

    public class Localizacion
    {
        [JsonPropertyName("lng")]
        public string Longitud { get; set; }
        [JsonPropertyName("lat")]
        public string Latitud { get; set; }
    }

    public class Compania
    {
        [JsonPropertyName("name")]
        public string NombreCompania{ get; set; }
        [JsonPropertyName("catchPhrase")]
        public string Frase{ get; set; }
        [JsonPropertyName("bs")]
        public string Bs{ get; set; }

    }
}