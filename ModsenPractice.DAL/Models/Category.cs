using ModsenPractice.DAL.Models.GeneralModels;

namespace ModsenPractice.DAL.Models
{
    public class Category : BaseModel
    {
        public string? Name { get; set; }
        public List<ProductCategory>? ProductCategory { get; } = [];
    }
}
