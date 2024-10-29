using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetAccountByIdAsync(int accountId);

        Task<Account> CreateAccount(Account account);

        Task<Account> UpdateAccount(Account account);

        Task<bool> DeleteAccount(int accountId);
    }
}
