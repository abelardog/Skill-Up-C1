using AlkemyWallet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlkemyWallet.Core.Models.DTO
{
    public class NewAccountDTO
    {


      
        public decimal Money { get; set; }
        public bool IsBlocked { get; set; }

        public int UserId { get; set; }




    }
}
