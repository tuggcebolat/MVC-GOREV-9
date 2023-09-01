using System.ComponentModel.DataAnnotations;

namespace GOREV_9.Models.Data.Entity
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }
        public int CategoryName{ get; set; }
        public string? CategoryDescription { get; set; }
        
    }
    
}
