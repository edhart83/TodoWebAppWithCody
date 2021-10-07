using System;
using System.Collections.Generic;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<TodoItem> theseTodos = new List<TodoItem>();
            theseTodos.Add(new TodoItem() { TodoID = 1, Name = "Go Running", IsComplete = false } );            
            modelBuilder.Entity<TodoItem>().HasData(theseTodos);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbcontextbuilder)
        {
            dbcontextbuilder.UseNpgsql("Host=localhost;Username=postgres;Password=new_password;Database=Todo");
        }
    }

}
