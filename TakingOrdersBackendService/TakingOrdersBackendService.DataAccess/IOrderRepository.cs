using Microsoft.EntityFrameworkCore;
using TakingOrdersBackendService.DataAccess.Models;

namespace TakingOrdersBackendService.DataAccess;

public interface IOrderRepository
{
    public DbSet<Order> Orders { get; }
    public Task SaveChangesAsync();
}