using AlkemyWallet.Repositories;
using AlkemyWallet.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlkemyWallet.Core.Services;
using AlkemyWallet.Entities;
using Microsoft.AspNetCore.Authorization;
using AlkemyWallet.DataAccess;
using AutoMapper;
using AlkemyWallet.Core.Models.DTO;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AlkemyWallet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FixedTermDepositController : ControllerBase
    {
        private readonly IFixedTermDepositService _fixedTermDepositServices;
        private readonly IMapper _mapper;
        public FixedTermDepositController(IFixedTermDepositService FixedTermDepositServices,IMapper mapper)
        {
            _fixedTermDepositServices = FixedTermDepositServices;
            _mapper = mapper;
        }

      
        [Authorize]
        [HttpGet("{id}")]
        public  async Task<IActionResult> GetFixedTermDepositById(int id)
        {
            FixedTermDepositEntity fixedDeposit = await _fixedTermDepositServices.getById(id);
            if (fixedDeposit == null) return NotFound(new { Status = "Not Fund", Message = "No FixedDeposit Fund" });
            else
            {
                var fixedDepositDto = _mapper.Map<FixedTermDepositDTO>(_fixedTermDepositServices.GetFixedTransactionDetailById(fixedDeposit));
                if (fixedDepositDto is null) return BadRequest(new { Status = "Not Fund", Message = "Not Fixed Deposit Fund" });
                else return Ok(fixedDepositDto);

            }
        }

   

   
        [HttpPost]
        [Authorize(Roles = "Regular")]
        public async Task<IActionResult> CreateFixedTermDeposit([FromBody] CreateFixedTermDepositDTO model) {

            if (ModelState.IsValid)
            {

                try
                {
                    await _fixedTermDepositServices.CreateFixedTermDeposit(model);
                    return Ok($"Fixed Term Deposit created succesfully. Amount deposited: " + model.Amount + "Closing Date: " + model.ClosingDate + ".");
            } catch (Exception Ex)
            {

                return BadRequest(Ex.Message);

            }
        }
            else { return BadRequest();}

        }


    }
}
