using Onyx.Domain.Entities;

namespace Onyx.DTO
{
    public class OrderItemDto : OrderItem
    {
        public OrderItemDto(string productName, int quantity, decimal unitPrice) : base(productName, quantity, unitPrice)
        {
            productName = productName;
            quantity = quantity;
            unitPrice = unitPrice;
        }
    }
}
