using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        List<Course> GetAllByCategoryId(int id);
        List<Course> GetByUnitPrice(decimal min, decimal max);


    }
}
