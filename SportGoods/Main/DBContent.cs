using SportGoods.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportGoods.Main
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<TennisRacket> TennisRacket { get; set; }
        public DbSet<CategoryTennisRacket> CategoryTennisRacket { get; set; }

     
    }
}