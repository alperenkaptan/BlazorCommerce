using BlazorDemo.Domain.DataAccess;
using BlazorDemo.Domain.SeedWorks;
using BlazorDemo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {

        private readonly BlazorDemoContext _dbContext;
        private DbSet<T> entities;

        public Repository(BlazorDemoContext dbContext)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _dbContext.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
