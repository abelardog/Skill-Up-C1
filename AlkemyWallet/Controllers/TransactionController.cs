using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Core.Services;
using AlkemyWallet.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlkemyWallet.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        public TransactionController(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }

        [HttpGet("{id")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var transactionDetail = await _transactionService.getById(id);
                if (transactionDetail is null)
                {
                    return NotFound();
                }
                return Ok(transactionDetail);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Status = "Bad Request", Message = $"Error: {ex.Message}" });
            }
            
        }
        
    }
}
