using ModsenPractice.DAL.Models.GeneralModels;

namespace ModsenPractice.DAL.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public List<Order> Orders { get; } = [];
    }
}
