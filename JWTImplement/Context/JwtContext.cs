using JWTImplement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace JWTImplement.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Employee> employees { get; set; }

    }
}
