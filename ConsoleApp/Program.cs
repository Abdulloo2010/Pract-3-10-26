using Domain.Models;

User user = new User(1,"Abdullo");
Category category = new Category(1,"C#");
Taskk taskk = new Taskk(1, "C#", "OOP", user, category);
taskk.TaskPriority=1;
TaskManager taskManager = new TaskManager();
taskManager.AddTask(taskk);
Console.WriteLine("Tasks: ");
taskManager.GetInfoAboutTasks();
taskk.Title = "C# OOP"; 
taskk.Description = "CRUD"; 
taskk.TaskPriority = 2; 
taskk.Done = true;

taskManager.UpdateTask(taskk);
Console.WriteLine("Update:"); 
taskManager.GetInfoAboutTasks();

taskManager.DeleteTask(2);

Console.WriteLine("Delete: ");
taskManager.GetInfoAboutTasks();