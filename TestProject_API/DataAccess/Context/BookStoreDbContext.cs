using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject_API.Models.Concrete;

namespace TestProject_API.DataAccess.Context
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> opt) : base(opt)
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
