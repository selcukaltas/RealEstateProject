using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.Models.Entities
{
    public class EstateType:Entity<int>
    {
      
        public string Type { get; set; }
        public virtual IEnumerable<Estate> Estates { get; set; }

    }
}
