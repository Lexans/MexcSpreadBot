using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MexcSpreadBot.Data
{
    public class DataBaseContextExchange : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Pair> Pairs { get; set; }
        public DbSet<Dex> Dexes { get; set; }

        public DataBaseContextExchange()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var path = Path.Combine(AppContext.BaseDirectory, "data\\DatabaseExchange.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

    }
}
