using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Data.Entity
{
    public class Fund
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
