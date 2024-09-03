using MediatR;
using Onyx.Command.Requests;
using Onyx.DTO;
using Onyx.Services.Interfaces;

namespace Onyx.Command.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IOrderService _orderService;

        public CreateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var dto = new CreateOrderDto { CustomerName = request.CustomerName, OrderDate = request.OrderDate };
            await _orderService.CreateOrderAsync(dto);
        }
    }
}
