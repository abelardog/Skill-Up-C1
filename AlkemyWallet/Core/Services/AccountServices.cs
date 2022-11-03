using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Core.Models.DTO;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories;
using AlkemyWallet.Repositories.Interfaces;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;

namespace AlkemyWallet.Core.Services
{
    public class AccountServices : IAccountService
    {

        private IUnitOfWork _unitOfWork;

        public AccountServices(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

        public void Delete(int AccountId)
        {

            var AccountToDelete = _unitOfWork.Accounts.getById(AccountId).Result;
            AccountToDelete.IsDeleted = true;
            _unitOfWork.Accounts.update(AccountToDelete);
            _unitOfWork.SaveChanges();

        }

        public IEnumerable<AccountEntity>GetAll(){


            return _unitOfWork.Accounts.getAll().Result.ToList();
        
        }

        public AccountEntity GetById(int userId)
        {
            return _unitOfWork.Accounts.getById(userId).Result;
        }

        public void insert(NewAccountDTO accountDTO)
        {
            //Do some Validations


            var NewAccount = new AccountEntity();

            NewAccount.CreationDate = DateTime.Now;
            NewAccount.User = _unitOfWork.User.getById(accountDTO.UserId).Result;
            NewAccount.IsBlocked = accountDTO.IsBlocked;
            NewAccount.UserId = accountDTO.UserId;
            NewAccount.Money = accountDTO.Money;

            _unitOfWork.Accounts.insert(NewAccount);
            _unitOfWork.SaveChanges();

        }

        public AccountEntity Update(UpdateAccountDTO updateAccountDTO)
        {

            var AccountToUpdate = _unitOfWork.Accounts.getById(updateAccountDTO.Id).Result;

            AccountToUpdate.CreationDate = updateAccountDTO.CreationDate;
            AccountToUpdate.User = _unitOfWork.User.getById(updateAccountDTO.UserId).Result;
            AccountToUpdate.IsBlocked = updateAccountDTO.IsBlocked;
            AccountToUpdate.UserId = updateAccountDTO.UserId;
            AccountToUpdate.Money = updateAccountDTO.Money;
            AccountToUpdate.IsDeleted = updateAccountDTO.IsDeleted;

            _unitOfWork.Accounts.update(AccountToUpdate);
            _unitOfWork.SaveChanges();

            return AccountToUpdate;

        }
    }
}
