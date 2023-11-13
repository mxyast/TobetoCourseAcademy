using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace DataAccess.Concrete.EntityFramework
{
    //NuGet 
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            //IDisposable pattern implementation c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //git bu veri kaynağından benim gönderdiğim producta nesne eşleştir
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Course, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Instructor>().SingleOrDefault(filter);
            }
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Course> GettAll(Expression<Func<Course, bool>> filter=null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Instructor>().ToList()
                    : context.Set<Instructor>()
                             .Where(filter)
                             .ToList();
            }
        }

        public void Update(Course entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }

        List<Course> IEntityRepository<Course>.GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}