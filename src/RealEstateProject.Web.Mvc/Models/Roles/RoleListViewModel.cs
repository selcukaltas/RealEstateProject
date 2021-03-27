using System.Collections.Generic;
using RealEstateProject.Roles.Dto;

namespace RealEstateProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
