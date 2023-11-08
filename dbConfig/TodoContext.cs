using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using SQLite.CodeFirst;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace todo_backend.Models
{
    public class TodoContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }


        
        public TodoContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = ConfigurationManager.ConnectionStrings["sqliteConn"].ToString(),
                ForeignKeys = true,


            }.ConnectionString

        }, true)
        
        {
            if (!Database.Exists())
            {
                Database.Create();
            }

        }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }

    }
}