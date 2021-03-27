using Abp.Application.Services;
using Abp.ObjectMapping;
using Abp.Specifications;
using RealEstateProject.AppService.Abstract;
using RealEstateProject.AppService.DTO;
using RealEstateProject.DomainServices;
using RealEstateProject.Models.Entities;
using RealEstateProject.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.AppService.Concrete
{
    public class EstateAppService : ApplicationService, IEstateAppService
    {
        private readonly IEstateManager _estateManager;
        private readonly IObjectMapper _objectMapper;

        public EstateAppService(IEstateManager estateManager, IObjectMapper objectMapper)
        {
            _estateManager = estateManager;
            _objectMapper = objectMapper;
        }

        public async Task Add(CreateEstateDto createEstateDto)
        {
           var estate = _objectMapper.Map<Estate>(createEstateDto);
           await _estateManager.Add(estate);
        }

        public async Task <IEnumerable<GetEstateDto>> GetFiltredEstates (FilteredEstateDto filteredList)
        {
            var spec = new EstateFilterSpecification(filteredList.squareMeter, filteredList.heatingTypeId, filteredList.floor, filteredList.numberOfLivingRooms, filteredList.numberOfRooms, filteredList.isFurnished, filteredList.totalNumberOfBuildingFloors, filteredList.estateTypeId, filteredList.districtId);
            var estate = _estateManager.GetAllEstates(spec.ToExpression());
            var dtoEstate = _objectMapper.Map<List<GetEstateDto>>(estate);
            return  dtoEstate;
        }
    }
}
