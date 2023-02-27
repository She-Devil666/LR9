using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.SQLite;
using System.Runtime.Remoting.Contexts;

namespace Stationery.Models
{
    public class DataBaseContext : DbContext
    {
        private static DataBaseContext _context;

        public DataBaseContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = "zakka.db",
                ForeignKeys = true
            }.ConnectionString
        }, true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<user> user { get; set; }
        public DbSet<basket> baskets { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<good> goods { get; set; }
        public DbSet<buyer> buyer { get; set; }

        public static DataBaseContext GetContext()
        {
            if (_context == null)
                _context = new DataBaseContext();
            return _context;
        }
    }
}
