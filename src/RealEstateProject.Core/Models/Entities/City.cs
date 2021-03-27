using Abp.Domain.Entities;
using System.Collections.Generic;

namespace RealEstateProject.Models.Entities
{
    public class City:Entity<int>
    {
       
        public string Name { get; set; }
        public virtual IEnumerable<District> Districts { get; set; }
    }
}