namespace GOREV_9.Models.Data.Entity
{
    public class Post
    {
        public int PostId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
       // public DateTime CreatedDate { get; set; }
       // public DateTime UpdatedDate { get; set;}

        public ICollection<PostImage> PostImages { get; set; }              
        public List<CategoryPost> PostCategories { get; set; }
    }
}
