namespace GOREV_9.Models.Data.Entity
{
    public class CategoryPost
    {  //dependent
        public int PostId { get; set; }
        public int CategoryId{ get;set;}
        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
