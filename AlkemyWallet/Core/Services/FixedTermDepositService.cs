using AlkemyWallet.Core.Helper;
using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Core.Models.DTO;
using AlkemyWallet.Core.Services.ResourceParameters;
using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;

namespace AlkemyWallet.Core.Services
{
    public class FixedTermDepositService : IFixedTermDepositService
    {
        private IUnitOfWork _unitOfWork;
        public FixedTermDepositService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task delete(FixedTermDepositEntity entity)
        {
            await _unitOfWork.FixedTermDepositRepository.delete(entity);
        }


        public async Task<IReadOnlyList<FixedTermDepositEntity>> getAll()
        {
            return await _unitOfWork.FixedTermDepositRepository.getAll();
        }

        public async Task<FixedTermDepositEntity> getById(int id)
        {
            return await _unitOfWork.FixedTermDepositRepository.getById(id);
        }

        public async Task saveChanges()
        {
            await _unitOfWork.FixedTermDepositRepository.saveChanges();
        }

        public async Task update(UpdateFixedTermDepositDTO model)
        {

            FixedTermDepositEntity fixedTermDepositEntity = _unitOfWork.FixedTermDepositRepository.getById(model.id).Result;
            
            if (fixedTermDepositEntity != null) 
            {
                fixedTermDepositEntity.User = _unitOfWork.UserRepository.getById((int)fixedTermDepositEntity.UserId).Result;
                fixedTermDepositEntity.Account = _unitOfWork.AccountsRepository.getById((int)fixedTermDepositEntity.AccountId).Result;
                fixedTermDepositEntity.Amount = model.Amount;
                fixedTermDepositEntity.ClosingDate = model.ClosingDate;
                fixedTermDepositEntity.CreationDate = model.CreationDate;
                fixedTermDepositEntity.IsDeleted = model.IsDeleted;
                

                await _unitOfWork.FixedTermDepositRepository.update(fixedTermDepositEntity);
                await _unitOfWork.Save();
            }
            else 
            {
                throw new Exception("Fixed Term Deposit Not Found, please check the ID");
            }

        }
        
        public FixedTermDepositEntity GetFixedTransactionDetailById(FixedTermDepositEntity fixedDeposit)
        {
            if (fixedDeposit.UserId == _unitOfWork.UserRepository.getById(fixedDeposit.UserId.Value).Id)
            {
                return  (fixedDeposit);
            }
            return null;
        }

        public async Task CreateFixedTermDeposit(CreateFixedTermDepositDTO model)
        {

            AccountsEntity UserAccount = _unitOfWork.AccountsRepository.getById(model.AccountId).Result;
            UserEntity User = _unitOfWork.UserRepository.getById(model.UserId).Result;

            if (UserAccount != null && User != null && model.ClosingDate >= DateTime.Now.AddDays(1)&& model.Amount>0)
            {
                if (UserAccount.Money >= model.Amount)
                {
                    UserAccount.Money -= model.Amount;
                    await _unitOfWork.AccountsRepository.update(UserAccount);
                    FixedTermDepositEntity NewFixedTermDepositEntity = new FixedTermDepositEntity();

                    NewFixedTermDepositEntity.User = User;
                    NewFixedTermDepositEntity.UserId = User.Id;
                    
                    
                    NewFixedTermDepositEntity.Account = UserAccount;
                    NewFixedTermDepositEntity.AccountId = UserAccount.Id;

                    NewFixedTermDepositEntity.Amount = model.Amount;
                    NewFixedTermDepositEntity.CreationDate = DateTime.Now;
                    NewFixedTermDepositEntity.ClosingDate = model.ClosingDate;
                    

                    await _unitOfWork.FixedTermDepositRepository.insert(NewFixedTermDepositEntity);
                    await _unitOfWork.Save();

                }
                else { throw new Exception("Insufficient balance"); }


            }
            else { throw new Exception("Incorrect Data - Check UserId, Account, Ammount and Closing Date. Remember that the closing Date must be greater than today"); }

            

        }

        public async Task<IReadOnlyList<FixedTermDepositEntity>> getTransactionsByUserId(int id)
        {
            return await _unitOfWork.FixedTermDepositRepository.getFixedTermDepositByUserId(id);
        }

        public async Task<PagedList<FixedTermDepositEntity>> getAll(PagesParameters pagesParams)
        {
            try
            {
                PagedList<FixedTermDepositEntity> ListFixedDeposit = _unitOfWork.FixedTermDepositRepository.getAll(pagesParams).Result;


                return ListFixedDeposit;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

      
    }
}
