using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                //Look for any Movies.
                if(context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Now,
                    Gnere = "Romantic Comedy",
                    Price = 7.99M
                },
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Now,
                        Gnere = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Now,
                        Gnere = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1959.02.03"),
                        Gnere = "Romantic Comedy",
                        Price = 7.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
