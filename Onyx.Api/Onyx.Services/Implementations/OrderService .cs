using Onyx.DTO;
using Onyx.Services.Interfaces;
using Onyx.Domain.Entities;


namespace Onyx.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task CreateOrderAsync(CreateOrderDto orderDto)
        {
            var order = new Order(orderDto.CustomerName, orderDto.OrderDate);
            // 添加订单到数据库
            await _orderRepository.AddAsync(order);
        }
    }
}
