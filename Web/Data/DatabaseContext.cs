using Web.Model;

namespace Web.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext()
        {

        }

        public DbSet<InputUrl> Url { get; set; }
        public DbSet<OutputUrl> Output { get; set; }
    }
}
