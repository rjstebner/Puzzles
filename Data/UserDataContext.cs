using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Puzzles.Models;

namespace Puzzles.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext (DbContextOptions<UserDataContext> options)
            : base(options)
        {
        }

        public DbSet<Puzzles.Models.UserModel> User { get; set; } = default!;
    }
}