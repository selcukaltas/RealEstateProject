using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateProject.AppService.DTO
{
    public class FilteredEstateDto
    {
        public double? squareMeter { get; set; }
        public int? numberOfLivingRooms { get; set; }
        public int? numberOfRooms { get; set; }
        public bool? isFurnished { get; set; }
        public int? floor { get; set; }
        public int? totalNumberOfBuildingFloors { get; set; }
        public int? estateTypeId { get; set; }
        public int? heatingTypeId { get; set; }
        public int? customerId { get; set; }
        public int? districtId { get; set; }
    }
}
