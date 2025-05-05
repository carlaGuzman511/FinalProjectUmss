using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;

namespace DonantsApp.Services.Accounts
{
    public class AccountService : IAccountService
    {
        internal readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }
        public Task<Account> CreateAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAccountAsync(int accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccountByIdAsync(int accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Account> UpdateAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
