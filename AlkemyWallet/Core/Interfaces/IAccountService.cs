using AlkemyWallet.Core.Models.DTO;
using AlkemyWallet.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AlkemyWallet.Core.Interfaces
{
    public interface IAccountService
    {
        public IEnumerable<AccountEntity> GetAll();
        public void insert(NewAccountDTO accountDTO);

        public AccountEntity GetById(int AccountId);

        public void Delete (int AccountId);

        public AccountEntity Update(UpdateAccountDTO updateAccountDTO);
    }
}
