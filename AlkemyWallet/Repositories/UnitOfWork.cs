using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace AlkemyWallet.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly WalletDbContext _context;

        public UnitOfWork(WalletDbContext context)
        {
            _context = context;
           
            Roles = new RolesRepository(_context);
            Accounts = new AccountsRepository(_context);
            User = new UserRepository(_context);
        }

        public IRoleRepository Roles { get;  set; }

        public IAccountsRepository Accounts { get; set; }

        public IUserRepository User { get;  set; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

