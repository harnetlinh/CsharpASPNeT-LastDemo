using Microsoft.EntityFrameworkCore;

namespace UserManagement.Data
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
        }
        public DbSet<UserManagement.Models.User> Users { get; set; }
        public DbSet<UserManagement.Models.Role> Roles { get; set; }
    }
}
