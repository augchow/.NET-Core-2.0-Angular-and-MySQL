using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountByOwner(Guid ownerId);
        IEnumerable<Account> GetAllAccount();
        void UpdateAccount(Account dbAccount, Account account);
        Account GetAccountById(Guid accountId);
    }
}
