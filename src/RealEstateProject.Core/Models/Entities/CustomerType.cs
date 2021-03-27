using Abp.Domain.Entities;
using System.Collections.Generic;

namespace RealEstateProject.Models.Entities
{
    public class CustomerType:Entity<int>
    {
        public string Type { get; set; }
        public virtual IEnumerable<CustomerTypeCustomer> Customers { get; set; }
    }
}