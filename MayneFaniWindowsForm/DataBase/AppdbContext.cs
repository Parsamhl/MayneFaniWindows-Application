using MayneFaniWindowsForm.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayneFaniWindowsForm.DataBase
{
    public class AppdbContext : DbContext
    {

        string connection = File.ReadAllText("C:\\Users\\Lion\\source\\repos\\MayneFaniWindowsForm\\MayneFaniWindowsForm\\bin\\Debug\\net8.0-windows\\DataBase.txt");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
