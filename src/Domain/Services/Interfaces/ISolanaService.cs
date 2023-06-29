namespace Domain.Services.Interfaces
{
    public interface ISolanaService
    {
        Task<ulong> GetBalance();
        Task<string> SendCurrencyAsync(ulong value);
    }
}
