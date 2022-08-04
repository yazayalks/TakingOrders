using Microsoft.AspNetCore.Mvc;
using TakingOrdersBackendService.BusinessLogic.Contracts;
using TakingOrdersBackendService.DTO;


namespace TakingOrdersBackendService.Controllers;

/// <summary>
/// Controller
/// </summary>
[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    /// <summary>
    ///  Constructor
    /// </summary>
    /// <param name="orderService"></param>
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    /// <summary>
    /// Get all Orders
    /// </summary>
    /// <returns>Orders</returns>
    [HttpGet(Name = "GetOrders")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<OrderDTO>> Get()
    {
        return await _orderService.GetAllOrdersAsync();
    }
    
    /// <summary>
    /// Create new order
    /// </summary>
    /// <param name="orderDto">NewOrder</param>
    [HttpPost(Name = "CreateOrder")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task Post(OrderDTO orderDto)
    {
        await _orderService.CreateOrderAsync(orderDto);
    }
}