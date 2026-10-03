namespace Domain.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }=null!;

    public User(int id, string name)
    {
        UserId=id;
        UserName=name;
    }
}
