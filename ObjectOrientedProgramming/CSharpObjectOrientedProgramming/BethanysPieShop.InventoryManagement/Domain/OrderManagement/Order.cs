﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.OrderManagement
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderFulfilmentDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public bool Fulfilled { get; set; } = false;

        public Order()
        {
            Id = new Random().Next(9999999);

            int numberOfSeconds = new Random().Next(100);
            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberOfSeconds);

            OrderItems = new List<OrderItem>();
        }

        public string ShowOrderDetails()
        {
            StringBuilder orderDetails = new StringBuilder();

            orderDetails.Append($"Order ID: {Id}");
            orderDetails.Append($"Order fulfilment date: {OrderFulfilmentDate.ToShortDateString()}");
            
            if (OrderItems != null)
            {
                foreach (OrderItem item in OrderItems)
                {
                    orderDetails.Append($"{item.ProductId}. {item.ProductName}:{item.AmountOrdered}");
                }
            }

            return orderDetails.ToString();
        }
    }
}
