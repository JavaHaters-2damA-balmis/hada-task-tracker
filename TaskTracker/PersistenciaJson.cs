using System.Text.Json;

namespace TaskTracker;

public class PersistenciaJson
{
    private readonly string rutaArchivo;

    public PersistenciaJson(string rutaArchivo = "tareas.json")
    {
        this.rutaArchivo = rutaArchivo;
    }

    public void Guardar(List<TaskItem> tareas)
    {
        var opciones = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(tareas, opciones);

        File.WriteAllText(rutaArchivo, json);
    }

    public List<TaskItem> Cargar()
    {
        if (!File.Exists(rutaArchivo))
        {
            return new List<TaskItem>();
        }

        string json = File.ReadAllText(rutaArchivo);

        return JsonSerializer.Deserialize<List<TaskItem>>(json)
               ?? new List<TaskItem>();
    }
}