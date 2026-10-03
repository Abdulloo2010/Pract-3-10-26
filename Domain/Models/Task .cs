namespace Domain.Models;

public class Taskk
{
    public int TaskId { get; set; }
    public string Title { get; set; }=null!;
    public string Description { get; set; }=null!;
    public User Assignee { get; set; }=null!;
    public Category TaskCategory { get; set; }
    public int TaskPriority { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt{ get; set; }

    public Taskk(int id,string title,string description,User assignee,Category taskCategory)
    {
        TaskId=id;
        Title=title;
        Description=description;
        Assignee=assignee;
        TaskCategory=taskCategory;
        Done=false;
        CreatedAt=DateTime.Now;
    }
}
