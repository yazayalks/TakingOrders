using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TakingOrdersBackendService.BusinessLogic.Contracts;
using TakingOrdersBackendService.DataAccess;
using TakingOrdersBackendService.DataAccess.Models;
using TakingOrdersBackendService.DTO;

namespace TakingOrdersBackendService.BusinessLogic.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task CreateOrderAsync(OrderDTO orderDto)
    {
        await _orderRepository.Orders.AddAsync(_mapper.Map<Order>(orderDto));
        await _orderRepository.SaveChangesAsync();
    }

    public async Task<List<OrderDTO>> GetAllOrdersAsync()
    {
        var orders = await _orderRepository.Orders.ToListAsync();
        return _mapper.Map<List<OrderDTO>>(orders);
    }
}