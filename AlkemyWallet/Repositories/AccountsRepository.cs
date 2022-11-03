using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;

namespace AlkemyWallet.Repositories
{
    public class AccountsRepository : GenericRepository<AccountEntity>, IAccountsRepository
    {
        public AccountsRepository(WalletDbContext walletDbContext) : base(walletDbContext)
        {
        }
    }
}
