using Microsoft.EntityFrameworkCore;
using OtakuLog.Api.Entities;

namespace OtakuLog.Api.Infrastructure;

/// <summary>
/// Database structure description.
/// </summary>
public class ApplicationDbContext : DbContext
{
    #region Constructors

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected ApplicationDbContext()
    {
    }

    #endregion

    #region Fields and properties

    public DbSet<User> Users => Set<User>();
    public DbSet<Anime> Animes => Set<Anime>();
    public DbSet<Genre> Genres => Set<Genre>();
    public DbSet<UserAnimeProgress> UserAnimeProgress => Set<UserAnimeProgress>();

    #endregion

    #region DbContext

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Anime>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(256).IsRequired();
            entity.Property(e => e.Russian).HasMaxLength(256).IsRequired();
            entity.Property(e => e.Episodes).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.HasMany(e => e.Genres)
                  .WithMany();
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(256).IsRequired();
            entity.Property(e => e.Russian).HasMaxLength(256).IsRequired();
            entity.Property(e => e.MediaKind).IsRequired();
        });

        modelBuilder.Entity<UserAnimeProgress>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.WatchedEpisodes).IsRequired();
            entity.Property(e => e.WatchStatus).IsRequired();
            entity.Property(e => e.Score);

            entity.HasOne(e => e.User)
                  .WithMany(u => u.AnimeProgressList)
                  .HasForeignKey(e => e.UserId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Anime)
                  .WithMany()
                  .HasForeignKey(e => e.AnimeId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Username).HasMaxLength(100).IsRequired();
            entity.Property(e => e.Email).HasMaxLength(256).IsRequired();
        });
    }

    #endregion
}
