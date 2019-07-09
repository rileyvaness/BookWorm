using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookWorm.Models
{
    public class BookWormContext : DbContext
    {
        public BookWormContext (DbContextOptions<BookWormContext> options)
            : base(options)
        {
        }

        public DbSet<BookWorm.Models.bookworm> bookworm { get; set; }
    }
}
