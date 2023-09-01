namespace GOREV_9.Models.Data.Entity
{
    public class Setting
    {
        public int Id { get; set; }
        public string PageId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Page Page { get; set; }
    }
}
