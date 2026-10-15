namespace TaskTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HADA TASK TRACKER!!!!!!");

        List<TaskItem> tasks = new List<TaskItem>

        ListarYCompletar(tasks);
    }

    public static void ListarYCompletar(List<TaskItem> tasks)
    {
        foreach (var task in tasks)
        {
            task.IsCompleted = true;
            
            Console.WriteLine(task.ToString());
        }
    }

    private static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("=== TaskTracker ===");
        Console.WriteLine("1. Añadir tarea");
        Console.WriteLine("2. Listar tareas");
        Console.WriteLine("3. Completar tarea");
        Console.WriteLine("0. Salir");
        Console.Write("Opción: ");
    }

    private static void AnadirTarea(List<TaskItem> tareas, ref int siguienteId)
    {
        Console.Write("Título de la tarea: ");
        var titulo = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(titulo))
        {
            Console.WriteLine("El título no puede estar vacío.");
            return;
        }

        tareas.Add(new TaskItem(siguienteId++, titulo));
        Console.WriteLine("Tarea añadida.");
    }

}