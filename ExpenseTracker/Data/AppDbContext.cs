﻿using ExpenseTracker.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Expenses> Expenses { get; set; } = default!;
        public DbSet<Note> Notes { get; set; } = default!;
        public DbSet<Fund> Funds { get; set; } = default!;
    }
}
