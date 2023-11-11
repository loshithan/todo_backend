using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Web;

namespace todo_backend.Models
{
    public class SQLiteConfig: DbConfiguration
    {
        //configuration for sqlite
        public SQLiteConfig()
        {
            SetProviderFactory("System.Data.SQLite",SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof (DbProviderServices)));



        }


    }
}