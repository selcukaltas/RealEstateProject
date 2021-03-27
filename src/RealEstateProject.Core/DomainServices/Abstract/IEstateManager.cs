using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Specifications;
using RealEstateProject.Models.Entities;
using RealEstateProject.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.DomainServices
{
    public interface IEstateManager:IDomainService
    {
        Task<IEnumerable<Estate>> GetAllEstates(Expression<Func<Estate, bool>> predicate= null);
        Task<IEnumerable<Estate>> GetAllIncluding(params Expression<Func<Estate, object>>[] includes);
        Task<Estate> GetById(int id);
        Task Add(Estate estate);
        Task Update(Estate estate);
        Task Delete(int id);
    }
}
