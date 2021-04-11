using System;
using System.Collections.Generic;
using EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirst.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}