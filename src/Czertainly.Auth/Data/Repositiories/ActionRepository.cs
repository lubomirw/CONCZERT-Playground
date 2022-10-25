﻿using Czertainly.Auth.Common.Data.Repositories;
using Czertainly.Auth.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Czertainly.Auth.Data.Repositiories
{
    public class ActionRepository : BaseRepository<Models.Entities.Action>, IActionRepository
    {
        public ActionRepository(AuthDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Models.Entities.Action?> GetActionByNameAsync(string actionName)
        {
            return await _dbSet.Where(a => a.Name.Equals(actionName, StringComparison.Ordinal)).FirstOrDefaultAsync();
        }

        public async Task<Dictionary<TKey, Models.Entities.Action>> GetActionsMapAsync<TKey>(Func<Models.Entities.Action, TKey> keySelector) where TKey : notnull
        {
            return await _dbSet.Include(a => a.Permissions).AsTracking().ToDictionaryAsync(keySelector);
        }
    }
}
