using AutoMapper;
using TakingOrdersBackendService.DataAccess.Models;
using TakingOrdersBackendService.DTO;

namespace TakingOrdersBackendService.BusinessLogic.AutoMapperProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderDTO>().ReverseMap();
    }
}