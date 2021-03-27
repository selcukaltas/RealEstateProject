using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.AppService.DTO
{
    [AutoMapTo(typeof(Estate))]
    public class CreateEstateDto:EntityDto
    {
        public double SquareMeter { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsFurnished { get; set; }
        public int Floor { get; set; }
        public int TotalNumberOfBuildingFloors { get; set; }
        public int EstateTypeId { get; set; }
        public int HeatingTypeId { get; set; }
        public int CustomerId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
