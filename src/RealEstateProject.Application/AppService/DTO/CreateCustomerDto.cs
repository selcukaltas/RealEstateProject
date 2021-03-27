using Abp.Application.Services.Dto;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.AppService.DTO
{
    public class CreateCustomerDto:EntityDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<int> CustomerTypes { get; set; }
    }
}
