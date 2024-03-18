using ExpenseTracker.Data.Entity;
using ExpenseTracker.Services.Contracts;

namespace ExpenseTracker.Services.Repositories
{
    public class ExpenseService : IExpenseService
    {
        public Task<(bool flag, string message)> AddOrUpdateExpensesAsync(Expenses expenses)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteExpensesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Expenses>> GetAllExpensesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
