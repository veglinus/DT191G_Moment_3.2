using Microsoft.EntityFrameworkCore;
namespace CDAPI;
public class AlbumContext : DbContext
{
    public AlbumContext(DbContextOptions options) : base(options) { }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Artist> Artists { get; set; }

    /*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<Album>()
        .HasKey(c => c.AlbumId);
    modelBuilder.Entity<Artist>()
        .HasKey(d => d.ArtistId);
    }
    */
}