using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.OrderProductRepository
{
    public class OrderProductRepository(dbContext dbContext) : GenericRepository<OrderProduct>(dbContext),  IOrderProductRepository
    { }
}
