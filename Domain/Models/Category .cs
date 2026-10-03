namespace Domain.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }=null!;

    public Category(int id,string name)
    {
        CategoryId=id;
        CategoryName=name;
    }
}
