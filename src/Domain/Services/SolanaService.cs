using Domain.Services.Interfaces;
using Solnet.Rpc;
using Solnet.Wallet;
using Solnet.Wallet.Bip39;

namespace Domain.Services
{
    public class SolanaService : ISolanaService
    {
        private readonly IRpcClient _client;
        private Wallet _wallet;
        
        public SolanaService(IRpcClient client)
        {
            _client = client;
            _wallet = new Wallet(WordCount.TwentyFour, WordList.English);
        }
        public async Task<ulong> GetBalance()
        {
            var balance = await _client.GetBalanceAsync(_wallet.Account.PublicKey);
            return balance.Result.Value;
        }

        public async Task<string> SendCurrencyAsync(ulong value)
        {
            var transactionHash = await _client.RequestAirdropAsync(_wallet.Account.PublicKey, 100_000_000);

            return transactionHash.Result;
        }
    }
}
