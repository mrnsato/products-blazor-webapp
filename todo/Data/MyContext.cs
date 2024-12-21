using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
}
