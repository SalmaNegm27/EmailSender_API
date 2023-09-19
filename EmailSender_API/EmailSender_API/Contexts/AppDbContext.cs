using EmailSender_API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailSender_API.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
     

        public DbSet<Message> Messages { get; set; }
    }
}
