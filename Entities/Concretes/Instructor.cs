using Entities.Abstracts;
using Entities.Concretes;

public class Instructor:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Instructor> Courses { get; set; }

}