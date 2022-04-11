using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleCodeFirst.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        { 
            
        }
        public DbSet<ToDoItem> ToDoItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ToDoItem>().HasData(

                new ToDoItem() { Id = 1, name = "Meeting with management", IsComplete = true, Description = "In meeting need to discuss some point" },
                new ToDoItem() { Id = 2, name = "Go For Shopping", IsComplete = false, Description = "List of items to buy" },
                new ToDoItem() { Id = 3, name = "Call someone to do task", IsComplete = true, Description = "Here is task to do on a call" });
           
            
        }

    }
}
