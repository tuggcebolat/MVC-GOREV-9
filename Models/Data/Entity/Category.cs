using System.ComponentModel.DataAnnotations;

namespace GOREV_9.Models.Data.Entity
{
    public class Category
    {
        
        public int CategoryId{ get; set; }
        public string? CategoryName{ get; set; }
        public string? CategoryDescription { get; set; }
        public List<CategoryPost> PostCategories { get; set; }
    }
    
}
