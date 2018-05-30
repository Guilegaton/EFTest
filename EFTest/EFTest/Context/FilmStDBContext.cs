using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFTest
{
    public class FilmStDBContext : DbContext
    {
        public DbSet<Track> Traks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public FilmStDBContext(DbContextOptions<FilmStDBContext> options)
            : base(options) { }
    }
}
