using Abp.Domain.Services;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.DomainServices.Abstract
{
    public interface ICustomerManager : IDomainService
    {
        Task<IEnumerable<Customer>> GetAllCustomers(Expression<Func<Customer, bool>> predicate = null);
        Task<Customer> GetById(int id);
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(int id);
        Task<IEnumerable<Customer>> GetAllIncluding(params Expression<Func<Customer, object>>[] includes);
    }
}
