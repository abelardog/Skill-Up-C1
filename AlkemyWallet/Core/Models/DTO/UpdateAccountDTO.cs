using AlkemyWallet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlkemyWallet.Core.Models.DTO
{
    public class UpdateAccountDTO
    {

        public int Id { get; set; } 
        public DateTime CreationDate { get; set; }
        public decimal Money { get; set; }
        public bool IsBlocked { get; set; }

        public bool IsDeleted { get; set; }

        public int UserId { get; set; }


        


    }
}
