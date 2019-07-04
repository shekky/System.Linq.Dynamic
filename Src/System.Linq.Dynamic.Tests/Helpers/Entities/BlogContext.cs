
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace System.Linq.Dynamic.Tests.Helpers.Entities
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbConnection connection)
            : base(connection, true)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
