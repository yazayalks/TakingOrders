using Microsoft.EntityFrameworkCore;
using TakingOrdersBackendService.DataAccess.Models;

namespace TakingOrdersBackendService.DataAccess;

public class EfOrderRepository : IOrderRepository
{
    private readonly OrderDbContext _orderDbContext;
    public EfOrderRepository(OrderDbContext orderDbContext)
    {
        _orderDbContext = orderDbContext;
    }

    public DbSet<Order> Orders => _orderDbContext.Orders;
    public async Task SaveChangesAsync()
    {
        await _orderDbContext.SaveChangesAsync();
    }
}