using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TheServer.Models;

namespace TheServer.Data
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        private string password = "";

        public UserContext(IConfiguration configuration) {
            password = configuration["PSSW"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Password={password}; User ID=sa;Initial Catalog=Coposc;Server=localhost");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
