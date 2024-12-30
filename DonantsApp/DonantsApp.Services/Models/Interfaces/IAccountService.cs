using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface IAccountService
    {
        Task<Account> GetAccountByIdAsync(int accountId);
        Task<Account> CreateAccountAsync(Account account);
        Task<Account> UpdateAccountAsync(Account account);
        Task<bool> DeleteAccountAsync(int accountId);
    }
}
