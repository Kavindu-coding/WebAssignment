using Microsoft.EntityFrameworkCore;
using web_assignment.Models;
using MovieRental.Model;

namespace web_assignment.ContextClass
{
    public class RentalContext:DbContext
    {
        public RentalContext(DbContextOptions<RentalContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> movies { get; set; }

        public DbSet<web_assignment.Models.Payment> Payment { get; set; } = default!;

        public DbSet<web_assignment.Models.Rental> Rental { get; set; } = default!;

        public DbSet<MovieRental.Model.User> User { get; set; } = default!;
    }
}
