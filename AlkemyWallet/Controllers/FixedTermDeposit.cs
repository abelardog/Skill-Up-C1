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

namespace AlkemyWallet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixedTermDepositController : ControllerBase
    {
        private readonly IFixedTermDepositServices _fixedTermDepositServices;
        private readonly WalletDbContext _context;
        private readonly IMapper _mapper;
        public FixedTermDepositController(IFixedTermDepositServices FixedTermDepositServices, WalletDbContext context, IMapper mapper)
        {
            _fixedTermDepositServices = FixedTermDepositServices;
            _context = context;
            _mapper = mapper;
        }

        [Route("api/[Controller]")]
        [Authorize]
        [HttpGet("{id}")]
        public  async Task<IActionResult> GetFixedTermDepositById(int id)
        {
            FixedTermDepositEntity fixedDeposit = await _fixedTermDepositServices.getById(id);
            if (fixedDeposit == null) return NotFound(new { Status = "Not Fund", Message = "No FixedDeposit Fund" });
            else
            {
                var fixedDepositDto = _fixedTermDepositServices.GetFixedTransactionDetailById(fixedDeposit)
                if (fixedDepositDto is null) return BadRequest(new { Status = "Not Fund", Message = "Not Fixed Deposit Fund" });
                else return Ok(fixedDepositDto);

            }
        }
    }
}
