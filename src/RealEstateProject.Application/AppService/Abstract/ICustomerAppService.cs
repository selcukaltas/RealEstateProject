using Abp.Application.Services;
using RealEstateProject.AppService.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.AppService.Abstract
{
    public interface ICustomerAppService:IApplicationService
    {
        Task Add(CreateCustomerDto createCustomerDto);
        Task<IEnumerable<GetCustomerDto>> GetAll();
        Task Delete(DeleteCustomerDto deleteCustomerDto);
        Task Update(UpdateCustomerDto updateCustomerDto);
    }
}
