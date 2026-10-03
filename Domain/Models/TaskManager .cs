namespace Domain.Models;

public class TaskManager
{
    private List<Taskk> tasks { get; set; }
    private List<User> users { get; set; }
    private List<Category> categories { get; set; }

    public TaskManager()
    {
        tasks = new List<Taskk>();
        users = new List<User>();
        categories = new List<Category>();
    }

    public List<Taskk> GetAllTasks()
    {
        return tasks;
    }

    public void AddTask(Taskk task)
    {
        tasks.Add(task);
    }

public Taskk GetTaskById(int id)
{
    for (int i = 0; i < tasks.Count; i++)
    {
        if (tasks[i].TaskId == id)
        {
            return tasks[i];
        }
    }
    return null;
}

    public void UpdateTask(Taskk task)
    {
        foreach (var item in tasks)
        {
            if (item.TaskId == task.TaskId)
            {
                item.Title=task.Title;
                item.Description=task.Description;
                item.TaskPriority=task.TaskPriority;
                item.Done=task.Done;
            }
        }
    }

public void DeleteTask(int id)
{
    for (int i = 0; i < tasks.Count; i++)
    {
        if (tasks[i].TaskId == id)
        {
            tasks.RemoveAt(i);
            return;
        }
    }
}

    public void GetInfoAboutTasks()
    {
        foreach (var task in tasks)
        {
                        Console.WriteLine($"Id: {task.TaskId}");
            Console.WriteLine($"Title: {task.Title}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"User: {task.Assignee.UserName}");
            Console.WriteLine($"Category: {task.TaskCategory.CategoryName}");
            Console.WriteLine($"Priority: {task.TaskPriority}");
            Console.WriteLine($"Done: {task.Done}");
            Console.WriteLine($"CreatedAt: {task.CreatedAt}");
            Console.WriteLine("----------------------");
        }
    }
      public List<Taskk> GetCompletedTasks()
    {
        List<Taskk> result = new List<Taskk>();
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].Done == true)
            {
                result.Add(tasks[i]);
            }
        }

        return result;
    }

       public List<Taskk> GetNotCompletedTasks()
    {
        List<Taskk> result = new List<Taskk>();
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].Done == false)
            {
                result.Add(tasks[i]);
            }
        }

        return result;
    }

    public List<Taskk> GetTasksByCategoryId(int categoryId)
{
    List<Taskk> result = new List<Taskk>();
    for (int i = 0; i < tasks.Count; i++)
    {
        if (tasks[i].TaskCategory.CategoryId == categoryId)
        {
            result.Add(tasks[i]);
        }
    }
    return result;
}

public List<Taskk> GetSortedTasks()
{
    tasks.Sort((a, b) => b.CreatedAt.CompareTo(a.CreatedAt));
    return tasks;
}

public List<Taskk> GetTasksByPriority(int priority)
{
    List<Taskk> result = new List<Taskk>();
    for (int i = 0; i < tasks.Count; i++)
    {
        if (tasks[i].TaskPriority == priority)
        {
            result.Add(tasks[i]);
        }
    }
    return result;
}
}
