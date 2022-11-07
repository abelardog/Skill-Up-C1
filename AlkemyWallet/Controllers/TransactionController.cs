using AlkemyWallet.Core.Interfaces;
using AlkemyWallet.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlkemyWallet.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transaction)
        {
            _transactionService = transaction;
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
                return BadRequest(new { Status = "Bad Request", Message = $"Bad Request: {ex.Message}" });
            }
            
        }
        
    }
}
