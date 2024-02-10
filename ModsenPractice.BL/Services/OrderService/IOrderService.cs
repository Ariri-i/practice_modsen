using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.BL.Services.OrderService
{
    public interface IOrderService
    {
        public void GetOrderList();

        public void AddOrder();

        public void UpdateOrder();

        public void DeleteOrder();
    }
}
