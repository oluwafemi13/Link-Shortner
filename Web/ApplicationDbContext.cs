using Microsoft.EntityFrameworkCore;
using Web.Model;

namespace Web;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);



        modelBuilder.Entity<OutputUrl>().HasOne<InputUrl>(i=>i.inputUrl)
                                  .WithOne(o=>o.outputUrl)
                                  
                                  .OnDelete(DeleteBehavior.Cascade);


    }

    public DbSet<InputUrl> Urls { get; set; }
    public DbSet<OutputUrl> Outputs { get; set; }
}
