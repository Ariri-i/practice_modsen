using ModsenPractice.DAL.Models.GeneralModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModsenPractice.DAL.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; } = null!;
        public int Cost { get; set; }

        public List<ProductCategory>? ProductCategory { get; } = [];
        public List<OrderProduct>? OrderProducts { get; } = [];
    }
}
