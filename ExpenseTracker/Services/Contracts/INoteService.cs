using ExpenseTracker.Data.Entity;

namespace ExpenseTracker.Services.Contracts
{
    public interface INoteService
    {
        Task<(bool flag, string message)> AddNoteAsync(Note note);
        Task<(bool flag, string message)> DeleteNoteAsync(int id);
        Task<List<Note>> GetNoteAsync();
    }
}
