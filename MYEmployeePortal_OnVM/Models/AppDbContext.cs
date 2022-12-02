using Microsoft.EntityFrameworkCore;
using MYEmployeePortal_OnVM.Models;
using System.Collections.Generic;

namespace MYEmployeePortal_OnVM.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}
