namespace TaskList.Context;

using Microsoft.EntityFrameworkCore;

public sealed class PostgreSqlContext : DbContext, IPostgreSqlContext
{
    public PostgreSqlContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<UserDto> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=Qwary123");
    }
}