using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApplication.Shared.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options):base(options) { }
        public DbSet<TaskModel> TaskModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().HasKey(x=>x.taskId);
        }
    }
}
