using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces.Models;
using System.Reflection;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DAL.Implementation.DB
{
  public  class DBContext :DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<CategoryFilm> CategoryFilms { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                    var configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build().GetSection("ConnectionString").Value;

        optionsBuilder.UseSqlServer(configuration);
        }
   

    }
}
