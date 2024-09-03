using MediatR;

namespace Onyx.Command.Requests
{
    public class CreateOrderCommand : IRequest
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
