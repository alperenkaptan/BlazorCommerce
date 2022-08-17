using BlazorDemo.Domain.SeedWorks;

namespace BlazorDemo.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseModel
        {
            IEnumerable<T> GetAll();
            T Get(int Id);
            void Insert(T entity);
            void Update(T entity);
            void Delete(T entity);
            void Remove(T entity);
            void SaveChanges();
        }
}
