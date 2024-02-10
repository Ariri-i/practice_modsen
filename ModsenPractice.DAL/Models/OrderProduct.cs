using System.ComponentModel.DataAnnotations.Schema;

namespace ModsenPractice.DAL.Models
{
    public class OrderProduct
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
