using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;
namespace AlkemyWallet.DataAccess.DataSeed
{
    public static class RoleDataSeeder
    {

                    
        public static void Initialize(WalletDbContext _context)
        {
            _context.Database.EnsureCreated();

            if (!_context.Roles.Any())
            {
                _context.Roles.Add(new RoleEntity { Name = "Admin", Description = "System Admin" });
                _context.Roles.Add(new RoleEntity { Name = "Regular", Description = "Regular User" });


                //Borrar, es solo para prueba:
            }

            if (!_context.Users.Any()) { 
            _context.Users.Add(new UserEntity {


                     FirstName="", 

                     LastName = "",

                     Email="Roberto@caeglos.com",

                    Password="password",

                    Points=5,

                    Role= _context.Roles.First(),
                       
                    RoleId = 1 });
            }

            _context.SaveChanges();
            
          

        }



    }
}
