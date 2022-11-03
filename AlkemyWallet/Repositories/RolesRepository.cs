using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Entity;

namespace AlkemyWallet.Repositories
{
    public class RolesRepository : GenericRepository<RoleEntity>, IRoleRepository
    {

       
        public RolesRepository(WalletDbContext walletDbContext) : base(walletDbContext)
        {
        }
    }
}
