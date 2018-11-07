using ImadErp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Data
{
    public class ERPDbContext:DbContext
    {
        public ERPDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TransactionDetails> TransactionDetail { get; set; }

    }
}
