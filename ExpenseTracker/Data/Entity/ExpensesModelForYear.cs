﻿namespace ExpenseTracker.Data.Entity
{
    public class ExpensesModelForYear
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
