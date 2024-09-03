﻿namespace Onyx.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public decimal GetTotalPrice()
        {
            return Quantity * UnitPrice;
        }
    }
}
