using System.Collections.Generic;
using RealEstateProject.Roles.Dto;

namespace RealEstateProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
