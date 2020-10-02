using Microsoft.EntityFrameworkCore;
using SolutionBD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.DataContext
{
    public class SqlServerDBContext : DbContext
    {
        public SqlServerDBContext(DbContextOptions<SqlServerDBContext> options) : base(options)
        {

        }
        public DbSet<AdminModel> AdminModel { set; get; }
    }
}
