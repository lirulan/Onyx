using Onyx.Domain.Enums;

namespace Onyx.Domain.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public string CustomerName { get; private set; }
        public DateTime OrderDate { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(string customerName, DateTime orderDate)
        {
            CustomerName = customerName;
            OrderDate = orderDate;
            Items = new List<OrderItem>();
            Status = OrderStatus.Pending;
        }

        public void AddItem(OrderItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Items.Add(item);
        }

        public void CompleteOrder()
        {
            if (Status != OrderStatus.Pending)
                throw new InvalidOperationException("只有待处理才可完成订单");

            Status = OrderStatus.Completed;
        }

        public void CancelOrder()
        {
            if (Status == OrderStatus.Completed)
                throw new InvalidOperationException("完成不允许取消");

            Status = OrderStatus.Cancelled;
        }
    }
}
