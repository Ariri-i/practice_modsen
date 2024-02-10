using ModsenPractice.DAL.Repository.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using ModsenPractice.DAL.Repository.OrderRepository;
using ModsenPractice.DAL.Models;

namespace ModsenPractice.BL.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void AddOrder()
        {
            var order = new Order();
            _orderRepository.Add(order);
        }

        public void DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public void GetOrderList()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
