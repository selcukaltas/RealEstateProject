using Abp.Domain.Entities;

namespace RealEstateProject.Models.Entities
{
    public class Photo:Entity<int>
    {
        public string PhotoPath { get; set; }
    }
}