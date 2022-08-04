using TakingOrdersBackendService.DTO;

namespace TakingOrdersBackendService.BusinessLogic.Contracts;

public interface IOrderService
{
    public Task CreateOrderAsync(OrderDTO orderDto);
    public Task<List<OrderDTO>> GetAllOrdersAsync();
}