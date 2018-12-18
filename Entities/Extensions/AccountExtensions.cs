using Entities.Models;

namespace Entities.Extensions
{
    public static class AccountExtensions
    {
        public static void Map(this Account dbAccount, Account account)
        {
            dbAccount.DateCreated = account.DateCreated;
            dbAccount.AccountType = account.AccountType;
            dbAccount.Owner_OwnerId = account.Owner_OwnerId;
        }
    }
}
