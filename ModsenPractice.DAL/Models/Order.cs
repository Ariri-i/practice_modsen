using ModsenPractice.DAL.Models.GeneralModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModsenPractice.DAL.Models
{
    public class Order : BaseModel
    {
        public string Name { get; set; } = null!;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public List<OrderProduct> OrderProducts { get; } = [];

    }
}
