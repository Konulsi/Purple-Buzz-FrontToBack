namespace FrontToBack.Models
{
    public class Work:BaseEntity
    {
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<WorkImage> WorkImages { get; set; }
    }
}
