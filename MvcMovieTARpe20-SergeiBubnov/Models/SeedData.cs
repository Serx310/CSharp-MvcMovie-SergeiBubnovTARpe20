using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovieTARpe20_SergeiBubnov.Data;
using System;
using System.Linq;

namespace MvcMovieTARpe20_SergeiBubnov.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieTARpe20_SergeiBubnovContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieTARpe20_SergeiBubnovContext>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {
                    AddMovies(context);   // DB has been seeded
                }


                // Look for any movies.
                if (!context.Actor.Any())
                {
                    AddActors(context);   // DB has been seeded
                }

                
                context.SaveChanges();
            }
        }

        private static void AddActors(MvcMovieTARpe20_SergeiBubnovContext context)
        {
            context.Actor.AddRange(
                new Actor
                {
                    FirstName = "Matt",
                    LastName = "Berry",
                    PlaceOfBirth = "UK",
                    Born = DateTime.Parse("1974-05-02"),
                    BeginningOfCarrier = DateTime.Parse("2004-01-29")
                },

                new Actor
                {
                    FirstName = "Natasia",
                    LastName = "Demetriou",
                    PlaceOfBirth = "UK",
                    Born = DateTime.Parse("1984-01-15"),
                    BeginningOfCarrier = DateTime.Parse("2012-01-01")
                }

            );
        }

        private static void AddMovies(MvcMovieTARpe20_SergeiBubnovContext context)
        {
            context.Movie.AddRange(
                                new Movie
                                {
                                    Title = "When Harry Met Sally",
                                    ReleaseDate = DateTime.Parse("1989-2-12"),
                                    Genre = "Romantic Comedy",
                                    Price = 7.99M,
                                    Rating = "R"
                                },

                                new Movie
                                {
                                    Title = "Ghostbusters ",
                                    ReleaseDate = DateTime.Parse("1984-3-13"),
                                    Genre = "Comedy",
                                    Price = 8.99M,
                                    Rating = "PG"
                                },

                                new Movie
                                {
                                    Title = "Ghostbusters 2",
                                    ReleaseDate = DateTime.Parse("1986-2-23"),
                                    Genre = "Comedy",
                                    Price = 9.99M,
                                    Rating = "PG"
                                },

                                new Movie
                                {
                                    Title = "Rio Bravo",
                                    ReleaseDate = DateTime.Parse("1959-4-15"),
                                    Genre = "Western",
                                    Price = 3.99M,
                                    Rating = "PG"
                                }
                            );
        }
    }
}