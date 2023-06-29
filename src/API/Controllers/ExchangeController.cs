using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("exchange")]
    public class ExchangeController : ControllerBase
    {
        private readonly ILogger<ExchangeController> _logger;
        private readonly ISolanaService _solanaService;
        public ExchangeController(ISolanaService solanaService, ILogger<ExchangeController> logger)
        {
            _logger = logger;
            _solanaService = solanaService;
        }

        [HttpGet("balance/")]
        public async Task<ulong> GetBalance()
        {
            return await _solanaService.GetBalance();
        }
        [HttpGet("balance/send/{value}")]
        public async Task<string> SendBalance(ulong value)
        {
            return await _solanaService.SendCurrencyAsync(value);
        }
    }
}