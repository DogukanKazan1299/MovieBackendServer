using Microsoft.EntityFrameworkCore;
using Movie.Core.Entities.Concrete;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataAccess.Concrete.Contexts
{
    public class MovieSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6AC6160; Database=AMovieServerDatabase; integrated security=true");
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<MoviePlayer> MoviePlayers { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<Moviee> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
