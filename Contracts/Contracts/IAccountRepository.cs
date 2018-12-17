using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountByOwner(Guid ownerId);
    }
}
