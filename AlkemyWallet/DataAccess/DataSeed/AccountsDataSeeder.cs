using AlkemyWallet.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System;

namespace AlkemyWallet.DataAccess.DataSeed
{
    public static partial class AccountsDataSeeder
    {

        public static void AccountsDataSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsEntity>().HasData(
                new { Id = 0, DateTime = new DateTime(), Money = 100.00, IsBlocked = false, user_id = 0 },
                new { Id = 1, DateTime = new DateTime(), Money = 100.00, IsBlocked = false, user_id = 0 },
                new { Id = 2, DateTime = new DateTime(), Money = 100.00, IsBlocked = false, user_id = 0 }
               );
        }

    }
}
