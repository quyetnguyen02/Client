using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ClientNews.Models;

namespace ClientNews.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=CrawDB")
        {
        }

        public DbSet<Sourses> Sourses { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}