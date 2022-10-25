﻿using Microsoft.EntityFrameworkCore.Storage;

namespace Czertainly.Auth.Data.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IRoleRepository Role { get; }
        IPermissionRepository Permission { get; }
        IResourceRepository Resource { get; }
        IActionRepository Action { get; }

        Task<IDbContextTransaction> BeginTransactionAsync();
        Task SaveAsync();
    }
}
