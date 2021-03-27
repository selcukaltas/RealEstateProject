using Abp.Domain.Repositories;
using Abp.Domain.Services;
using RealEstateProject.DomainServices.Abstract;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.DomainServices.Concrete
{
    public class CustomerManager : DomainService, ICustomerManager
    {
        private readonly IRepository<Customer> _repository;
        public CustomerManager(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Add(Customer customer)
        {
           await _repository.InsertAsync(customer);
        }

        public async Task Delete(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers(Expression<Func<Customer, bool>> predicate = null)
        {
            return await _repository.GetAllListAsync(predicate);
        }

        public async Task<IEnumerable<Customer>> GetAllIncluding(params Expression<Func<Customer, object>>[] includes)
        {
            return await Task.Run(() => _repository.GetAllIncluding(includes));
        }
        public async Task<Customer> GetById(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task Update(Customer customer)
        {
            await _repository.UpdateAsync(customer);
        }
    }
}
