using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContent(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}