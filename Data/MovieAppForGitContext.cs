using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies.Models;

namespace MovieAppForGit.Data
{
    public class MovieAppForGitContext : DbContext
    {
        public MovieAppForGitContext (DbContextOptions<MovieAppForGitContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
