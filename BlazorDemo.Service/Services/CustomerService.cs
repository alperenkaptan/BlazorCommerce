using BlazorDemo.Domain.Models;
using BlazorDemo.Repository.Interfaces;
using BlazorDemo.Service.Interfaces;

namespace BlazorDemo.Service.Services
{
    public class CustomerService : ICustomeService<Customer>
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Delete(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    _customerRepository.Delete(entity);
                    _customerRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Customer Get(int Id)
        {
            try
            {
                var obj = _customerRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Customer> GetAll()
        {
            try
            {
                var obj = _customerRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    _customerRepository.Insert(entity);
                    _customerRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    _customerRepository.Remove(entity);
                    _customerRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Customer entity)
        {
            try
            {
                if (entity != null)
                {
                    _customerRepository.Update(entity);
                    _customerRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
