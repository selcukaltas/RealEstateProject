using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.AppService.DTO
{
    [AutoMapTo(typeof(List<Estate>))]
    public class GetEstateDto:EntityDto
    {
        public double SquareMeter { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsFurnished { get; set; }
        public int Floor { get; set; }
        public int TotalNumberOfBuildingFloors { get; set; }
        public virtual EstateType EstateType { get; set; }
        public virtual HeatingType HeatingType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual District District { get; set; }
        public string Address { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
