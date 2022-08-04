using Microsoft.EntityFrameworkCore;
using TakingOrdersBackendService.DataAccess.Models;

namespace TakingOrdersBackendService.DataAccess;

public class OrderDbContext: DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options){}
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TakingOrders;Username=postgres;Password=6969");
    }
}