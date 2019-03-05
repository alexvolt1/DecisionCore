using System;
using System.Collections.Generic;
using System.Text;
using DecisionCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DecisionCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
