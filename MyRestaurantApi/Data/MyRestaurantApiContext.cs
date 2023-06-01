using Microsoft.EntityFrameworkCore;

namespace MyRestaurantApi.Data;

public class MyRestaurantApiContext : DbContext
{
    public MyRestaurantApiContext(DbContextOptions<MyRestaurantApiContext> options)
        : base(options)
    {
    }

    public DbSet<Contact> Contact { get; set; } = default!;
    public DbSet<MenuItem> MenuItem { get; set; } = default!;
    public DbSet<MenuItemOrdered> MenuItemOrdered { get; set; } = default!;
    public DbSet<TogoOrder> TogoOrder { get; set; } = default!;
}
