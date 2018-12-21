using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Config
{
    public class ContextBase : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }
        public ContextBase(DbContextOptions<ContextBase> option) : base(option)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(RefreshUrlConnection());
            }
        }


        public string RefreshUrlConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            Configuration = builder.Build();
            string connectString = Configuration.GetConnectionString("DefaultConnection");
            return connectString;
        }
    }
}
