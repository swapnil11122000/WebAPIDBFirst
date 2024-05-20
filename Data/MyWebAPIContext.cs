using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Model;

namespace MyWebAPI.Data
{
    public class MyWebAPIContext : DbContext
    {
        public MyWebAPIContext (DbContextOptions<MyWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebAPI.Model.Book> Book { get; set; } = default!;
    }
}
