using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System.Collections.Generic;

namespace RealEstateProject.Models.Entities
{
    public class Customer:Entity<int>
    {
        
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<CustomerTypeCustomer> CustomerTypes { get; set; }
    }
}