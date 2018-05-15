using BlogEntity.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogEntity.Infra
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}