﻿namespace ExpenseTracker.Data.Entity
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime? DateAdded { get; set; }
    }
}
