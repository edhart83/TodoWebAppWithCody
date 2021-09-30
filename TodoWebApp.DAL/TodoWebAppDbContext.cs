using System;
using Microsoft.EntityFrameworkCore;
using TodoWebApp.CORE;

namespace TodoWebApp.DAL
{
    public class TodoWebAppDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoWebAppDbContext() : base()
        {
            
        }
        public TodoWebAppDbContext(DbContextOptions options) : base( options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbcontextbuilder)
        {
            dbcontextbuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=FullApp");
        }
    }

}
