﻿using BanglaRunnersWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BanglaRunnersWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresss { get; set; }
        
    }
}
