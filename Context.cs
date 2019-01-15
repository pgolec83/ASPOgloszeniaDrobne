using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public Context() : base()
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }
    }
}