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

namespace RealEstateProject.DomainServices.Concrete
{
    public class EstateManager : DomainService, IEstateManager
    {
        private readonly IRepository<Estate> _repository;
        public EstateManager(IRepository<Estate> repository)
        {
            _repository = repository;
        }
        public async Task Add(Estate estate)
        {
            await _repository.InsertAsync(estate);
        }
        public async Task Delete(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Estate>> GetAllEstates(Expression<Func<Estate, bool>> predicate = null)
        {
            return await _repository.GetAllListAsync(predicate);
        }

        public async Task<IEnumerable<Estate>> GetAllIncluding(params Expression<Func<Estate,object>>[] includes)
        {

            return await Task.Run(() => _repository.GetAllIncluding(includes));
        }

        public async Task<Estate> GetById(int id)
        {
            return await _repository.GetAsync(id);
        }
        public async Task Update(Estate estate)
        {
            await _repository.UpdateAsync(estate);
        }
    }
}
