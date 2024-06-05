using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI;

namespace MoviesAPI.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesAPI.Movie> Movies { get; set; } = default!;

        public void SeedData()
        {
            if (Movies.Any() == false)
            {
                Movies.Add(new MoviesAPI.Movie
                {
                    ID = 1,
                    Name = "Test",
                    Description = "This is for test",
                    CreatedDate = DateTime.Now,
                });
                this.SaveChanges();
            }
        }

    }
}
