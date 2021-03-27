using Abp.Application.Services;
using Abp.Specifications;
using RealEstateProject.AppService.DTO;
using RealEstateProject.Models.Entities;
using RealEstateProject.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.AppService.Abstract
{
    public interface IEstateAppService:IApplicationService
    {
        Task Add(CreateEstateDto createEstateDto);
        Task <IEnumerable<GetEstateDto>> GetFiltredEstates (FilteredEstateDto filteredList);

    }
}
