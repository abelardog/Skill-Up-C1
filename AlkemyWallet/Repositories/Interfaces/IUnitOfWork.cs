using AlkemyWallet.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlkemyWallet.Repositories.Interfaces
{
    public interface IUnitOfWork
    {

        //public IGenericRepository<EntityBase> RepositorioGenerico();

        //IRoleRepository Roles { get; }
        IAccountsRepository Accounts { get; }

        IUserRepository User { get; }
        public void SaveChanges();


    }
}
