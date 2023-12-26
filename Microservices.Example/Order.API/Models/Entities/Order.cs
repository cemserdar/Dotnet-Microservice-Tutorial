﻿using Order.API.Models.Enums;

namespace Order.API.Models.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid BuyerId { get; set; }
        public decimal TotalPrice { get; set; }
        //public List<OrderItem> OrderItems { get; set; }
        public OrderStatus OrderStatu { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
