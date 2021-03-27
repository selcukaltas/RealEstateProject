using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.Models.Entities
{
    public class CustomerTypeCustomer
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerTypeId { get; set; }
        public virtual CustomerType CustomerType { get; set; }
    }
}
