using Microsoft.EntityFrameworkCore;
using Puzzles.Data;

namespace Puzzles.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new UserDataContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<UserDataContext>>()))
        {
            if (context == null || context.User == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            context.User.AddRange(
                new UserModel
                {
                    Username = "cammie",
                    Password = "hello"
                });
            context.SaveChanges();
        }
    }
}