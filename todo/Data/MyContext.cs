using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class MyContext(DbContextOptions<MyContext> options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
}
