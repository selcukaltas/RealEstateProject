using Abp.Application.Services;
using Abp.ObjectMapping;
using RealEstateProject.AppService.Abstract;
using RealEstateProject.AppService.DTO;
using RealEstateProject.DomainServices.Abstract;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.AppService.Concrete
{
    public class CustomerAppService : ApplicationService, ICustomerAppService
    {
        private readonly ICustomerManager _customerManager;
        private readonly IObjectMapper _objectMapper;
        public CustomerAppService(ICustomerManager customerManager, IObjectMapper objectMapper)
        {
            _customerManager = customerManager;
            _objectMapper = objectMapper;
        }

        public async Task Add(CreateCustomerDto createCustomerDto)
        {
            var customer = _objectMapper.Map<Customer>(createCustomerDto);
            await _customerManager.Add(customer);
        }
     

        public async Task Delete(DeleteCustomerDto deleteCustomerDto)
        {
            await _customerManager.Delete(deleteCustomerDto.Id);

        }

        public async Task<IEnumerable<GetCustomerDto>> GetAll()
        { 
            var customer = await _customerManager.GetAllCustomers();
            var dtoCustomer = _objectMapper.Map<List<GetCustomerDto>>(customer);
            return dtoCustomer;
        }
        public async Task Update(UpdateCustomerDto updateCustomerDto)
        {
            var updateEstate = _objectMapper.Map<Customer>(updateCustomerDto);
            await _customerManager.Update(updateEstate);
        }
    }
}
