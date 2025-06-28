using obtenerChiste;
using System.Text.Json;

var listaChistes = await ObtenerChiste.GetChistes();

foreach (var chiste in listaChistes)
{
    Console.WriteLine($"Categoria: {chiste.Categoria} | Chiste: {chiste.Contenido}");
}

guardarArchivo(JsonSerializer.Serialize(listaChistes));


void guardarArchivo(string cadena)
{
    string ruta = "./chistes.json";
    using (StreamWriter sw = new StreamWriter(ruta))
    {
        sw.Write(cadena);
    }

}