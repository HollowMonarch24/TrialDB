using Microsoft.EntityFrameworkCore;
using TrialDB.Models;

namespace TrialDB.Model
{
    public class AdminContext : DbContext
    {
        public DbSet<AdminCredentials> Credentials { get; set; }

        public AdminContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
