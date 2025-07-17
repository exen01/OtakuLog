using Microsoft.EntityFrameworkCore;
using OtakuLog.Domain.Entities;

namespace OtakuLog.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Anime> Anime { get; set; }
}