using Contracts;
using Entities;
using Entities.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            
        }

        public IEnumerable<Account> AccountByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.Owner_OwnerId.Equals(ownerId));
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return FindAll()
                .OrderBy(ac => ac.DateCreated);
        }

        public Account GetAccountById(Guid accountId)
        {
            return FindByCondition(account => account.Id.Equals(accountId))
                    .DefaultIfEmpty(new Account())
                    .FirstOrDefault();
        }

        public void UpdateAccount(Account dbAccount, Account account)
        {
            dbAccount.Map(account);
            Update(dbAccount);
            Save();
        }
    }
}