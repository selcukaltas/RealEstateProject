﻿using System.Threading.Tasks;
using Abp.Application.Services;
using RealEstateProject.Authorization.Accounts.Dto;

namespace RealEstateProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
