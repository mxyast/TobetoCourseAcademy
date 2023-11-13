using Business.Concretes;
using DataAccess.Concrete.EntityFramework;
using Entities.Concretes;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());

            foreach (var course in courseManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(course.Name);
            }

        }
    }
}