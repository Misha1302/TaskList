namespace TaskList.Context;

using Microsoft.EntityFrameworkCore;

public interface IPostgreSqlContext
{
    public DbSet<UserDto> Users { get; set; }
}