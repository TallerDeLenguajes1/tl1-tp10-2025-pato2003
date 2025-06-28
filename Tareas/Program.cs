using System.Text.Json;
using obtenerTareas;

var tareas = await ObtenerTareas.GetTareas();

foreach (var tarea in tareas)
{
    if (!tarea.Completada)
    {
        Console.WriteLine($"Título: {tarea.Titulo} | Estado: Pendiente"); 
    }
}
foreach (var tarea in tareas)
{
    if (tarea.Completada)
    {
        Console.WriteLine($"Título: {tarea.Titulo} | Estado: Completada");
    }
}

guardarEnArchivo(JsonSerializer.Serialize(tareas));


void guardarEnArchivo(string cadena)
{
    string ruta = @"./tareas.json";
    using (StreamWriter sw = new StreamWriter(ruta))
    {
        sw.Write(cadena);
    }

}
