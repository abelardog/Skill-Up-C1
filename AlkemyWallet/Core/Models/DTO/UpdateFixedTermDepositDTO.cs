﻿namespace AlkemyWallet.Core.Models.DTO
{
    public class UpdateFixedTermDepositDTO
    {

        public int id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosingDate { get; set; }
       
    }
}
