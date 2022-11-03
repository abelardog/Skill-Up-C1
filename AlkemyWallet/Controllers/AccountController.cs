using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Core.Models.DTO;
using AlkemyWallet.Core.Services;
using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories;
using AlkemyWallet.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlkemyWallet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {


        private IAccountService _accountServices;

        public AccountController(IAccountService accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAccounts()
        {


            return Ok(_accountServices.GetAll());
      
        
        }


        [HttpPost]
        [Route("Create")]
        public IActionResult Save([FromBody] NewAccountDTO accountDTO)
        {
            if (ModelState.IsValid)
            {
                _accountServices.insert(accountDTO);
                return Ok();
            }
            else
            {

                return BadRequest("Surgió un error, intentelo nuevamente.");
            }

            
        }


        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int AccountId)
        {
           
               return Ok(_accountServices.GetById(AccountId));
           
        }


        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int AccountId)
        {

            _accountServices.Delete(AccountId);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(UpdateAccountDTO updateAccountDTO)
        {

            _accountServices.Update(updateAccountDTO);
            return Ok();
        }

     



    }
}
