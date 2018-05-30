using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTest
{
    public class FilmStDbContextFactory : IDesignTimeDbContextFactory<FilmStDBContext>
    {
        public FilmStDBContext CreateDbContext(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<FilmStDBContext>();
            optionsBuilder.UseSqlServer("Server=tcp:filmsterrserver.database.windows.net,1433;Initial Catalog=filmsterr;Persist Security Info=False;User ID=animtel;Password=12345678Fn;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new FilmStDBContext(optionsBuilder.Options);
        }
    }
}
