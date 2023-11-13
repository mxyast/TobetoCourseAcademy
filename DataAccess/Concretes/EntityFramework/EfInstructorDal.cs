using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet 
    public class EfInstructorDal : IInstructorDal
    {
        public void Add(Instructor entity)
        {
            //IDisposable pattern implementation c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //git bu veri kaynağından benim gönderdiğim producta nesne eşleştir
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Instructor entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Instructor>().SingleOrDefault(filter);
            }
            
        }

        public List<Course> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GettAll(Expression<Func<Instructor, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Instructor>().ToList()
                    : context.Set<Instructor>().Where(filter).ToList();
            }
        }

        public List<Instructor> GettAll(Expression<Func<Instructor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        List<Course> IEntityRepository<Instructor>.GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}