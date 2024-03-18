using ExpenseTracker.Data.Entity;

namespace ExpenseTracker.Services.Contracts
{
    public interface IExpenseService
    {
        Task<(bool flag, string message)> AddOrUpdateExpensesAsync(Expenses expenses);
        Task<List<Expenses>> GetAllExpensesAsync();
        Task<bool> DeleteExpensesAsync(int id);
    }
}
