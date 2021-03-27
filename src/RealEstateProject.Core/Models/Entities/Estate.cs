using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.Models.Entities
{
    public class Estate:Entity<int>
    {
        public Estate()
        {
            Photos = new HashSet<Photo>();
        }
        public double SquareMeter { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsFurnished { get; set; }
        public int Floor { get; set; }
        public int TotalNumberOfBuildingFloors { get; set; }
        public int EstateTypeId { get; set; }
        public virtual EstateType EstateType { get; set; }
        public int HeatingTypeId { get; set; }
        public virtual HeatingType HeatingType { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public string Address { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
