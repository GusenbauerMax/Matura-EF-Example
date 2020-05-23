using Microsoft.EntityFrameworkCore;
using Songs.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs.Server.Data
{
    public class SongDataContext : DbContext
    {
        public SongDataContext(DbContextOptions<SongDataContext> options)
        : base(options)
        { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Interpreter> Interpreters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Interpreter)
                .WithMany(i => i.Songs);
        }
    }
}
