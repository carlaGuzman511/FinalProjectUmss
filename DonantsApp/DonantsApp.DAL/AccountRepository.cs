using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;

namespace DonantsApp.DAL
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string _connectionString; 
        public AccountRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Task<Account> CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAccount(int accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccountByIdAsync(int accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Account> UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
