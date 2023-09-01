namespace GOREV_9.Models.Data.Entity
{
    public class Page
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Post? Post { get; set; }
        public ICollection<Setting> ?Setting { get; set; }
    }
}
