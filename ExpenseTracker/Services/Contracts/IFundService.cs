using ExpenseTracker.Data.Entity;

namespace ExpenseTracker.Services.Contracts
{
    public interface IFundService
    {
        Task<int> AddFundAsync(Fund fund);
        Task<decimal> GetAvailableFund();
    }
}
