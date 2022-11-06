using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;

namespace AlkemyWallet.Core.Services
{
    public class FixedTermDepositService : IFixedTermDepositServices
    {
        private IUnitOfWork _unitOfWork;
        public FixedTermDepositService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public GetFixedTransactionDetailById(FixedTermDepositEntity fixedDeposit){
            if (fixedDeposit.UserId == _context.Users.Find(fixedDeposit.UserId).Id)
                    return _mapper.Map<FixedTermDepositDTO>(fixedDeposit);
             else return null;
        }
        
    }
}
