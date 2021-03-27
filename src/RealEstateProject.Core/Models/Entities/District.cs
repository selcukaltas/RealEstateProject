using Abp.Domain.Entities;

namespace RealEstateProject.Models.Entities
{
    public class District:Entity<int>
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}