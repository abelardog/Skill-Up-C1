﻿using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;

namespace AlkemyWallet.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<RoleEntity> _rolesRepository;
        private WalletDbContext _walletDbContext;

        public UnitOfWork(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
        }

        public IGenericRepository<RoleEntity> RolesRepository
        {
            get
            {
                  return _rolesRepository = _rolesRepository ?? new GenericRepository<RoleEntity>(_walletDbContext);
            }
        }

        public void Save()
        {
            _walletDbContext.SaveChanges();
        }
    }
}
