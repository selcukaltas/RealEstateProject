using System.Collections.Generic;
using RealEstateProject.Roles.Dto;

namespace RealEstateProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}