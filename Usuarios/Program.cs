using usuario;
using obtenerUsuario;
using System.Text.Json;

var listaUsuarios = await ObtenerUsuario.GetUsuarios();

Console.WriteLine("-------------------USUARIOS-------------------\n");
foreach (var usuario in listaUsuarios)
{
    Console.WriteLine($"Nombre: {usuario.Nombre} | Email: {usuario.Mail} | Domicilio: {usuario.Direc.Calle} {usuario.Direc.Numero} | ");
}
Console.WriteLine("\n----------------------------------------------");

escribirArchivo(JsonSerializer.Serialize(listaUsuarios));


void escribirArchivo(string cadena)
{
    string ruta = "./usuarios.json";
    using (StreamWriter sw = new StreamWriter(ruta))
    {
        sw.Write(cadena);
    }
}