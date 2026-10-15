namespace TaskTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HADA TASK TRACKER!!!!!!");

        List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem (1, "Task 1"),
            new TaskItem (2, "Task 2"),
            new TaskItem (3, "Task 3")
        };
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
}