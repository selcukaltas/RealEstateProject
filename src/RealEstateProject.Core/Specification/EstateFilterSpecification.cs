using Abp.Specifications;
using RealEstateProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RealEstateProject.Specification
{
    public class EstateFilterSpecification : Specification<Estate>
    {
        private readonly int? _heatingTypeId;
        private readonly int? _floor;
        private readonly int? _numberOfLivingRooms;
        private readonly int? _numberOfRooms;
        private readonly bool? _isFurnished;
        private readonly double? _squareMeter;
        private readonly int? _estateTypeId;
        private readonly int? _districtId;
        private readonly int? _totalNumberOfBuildings;


        public EstateFilterSpecification(double? squareMeter,int? heatingTypeId,int? floor,int? numberOfLivingRooms,int? numberOfRooms,bool? isFurnished,int? totalNumberOfBuildings,int? estateTypeId,int? districtId)
        {
            _heatingTypeId = heatingTypeId;
            _estateTypeId = estateTypeId;
            _floor = floor;
            _numberOfRooms = numberOfRooms;
            _numberOfLivingRooms = numberOfLivingRooms;
            _isFurnished = isFurnished;
            _districtId = districtId;
            _totalNumberOfBuildings = totalNumberOfBuildings;
        }
        public override Expression<Func<Estate, bool>> ToExpression()
        {
            return (x => (!_estateTypeId.HasValue || x.EstateTypeId == _estateTypeId) &&
            (!_squareMeter.HasValue || x.SquareMeter >= _squareMeter) &&
            (!_numberOfRooms.HasValue || x.NumberOfRooms == _numberOfRooms) &&
            (!_floor.HasValue || x.Floor >= _floor) &&
            (!_totalNumberOfBuildings.HasValue || x.TotalNumberOfBuildingFloors >= _totalNumberOfBuildings) &&
            (!_heatingTypeId.HasValue || x.HeatingTypeId == _heatingTypeId)&&(!_districtId.HasValue|| x.DistrictId==_districtId)&&(x.IsFurnished==_isFurnished)&&(!_numberOfLivingRooms.HasValue||x.NumberOfLivingRooms>=_numberOfLivingRooms));
        }
    }
}
