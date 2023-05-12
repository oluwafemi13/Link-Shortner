using Microsoft.EntityFrameworkCore;
using Web.Model;

namespace Web.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<InputUrl> Url { get; set; }
        public DbSet<OutputUrl> Output { get; set; }
    }
}
