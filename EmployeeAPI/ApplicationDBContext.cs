using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeAPI
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
