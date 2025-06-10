
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WattCount.Models;

namespace MauiBasics.Services {


    public class DbManagerSQLite : DbContext {

        public DbSet<Teams> Teams { get; set; }

        public DbManagerSQLite() {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "app_db_local.sqlite");

            // C:\\Users\\fabia\\AppData\\Local\\User Name\\com.companyname.wattcount\\Data\\app_db_local.sqlite

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}
