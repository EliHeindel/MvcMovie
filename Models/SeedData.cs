using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "PG",
                        Price = 3.99M
                    },
                    // Adding new movies
                    new Movie
                    {
                        Title = "Meatballs",
                        ReleaseDate = DateTime.Parse("1979-6-29"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 5.99M
                    },
                    new Movie
                    {
                        Title = "Caddyshack",
                        ReleaseDate = DateTime.Parse("1980-7-25"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 6.99M
                    },
                    new Movie
                    {
                        Title = "Cool Hand Luke",
                        ReleaseDate = DateTime.Parse("1967-11-1"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 4.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
