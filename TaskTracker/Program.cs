internal class Program
{
    private static void Main(string[] args)
    {
        List<TaskItem> tareas = new List<TaskItem>();

        int siguienteId = 1;
        bool salir = false;

        while (!salir)
        {
            MostrarMenu();

            switch (Console.ReadLine()?.Trim())
            {
                case "1":
                    AnadirTarea(tareas, ref siguienteId);
                    break;
                case "2":
                    Console.WriteLine("Listar tareas: pendiente (otra rama).");
                    break;
                case "3":
                    Console.WriteLine("Completar tarea: pendiente (otra rama).");
                    break;
                case "0":
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Elige una opción del menú.");
                    break;
            }
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