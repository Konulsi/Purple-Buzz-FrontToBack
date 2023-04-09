namespace FrontToBack.Models
{
    public class Package: BaseEntity
    {
        public string Price { get; set; }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }

    }
}
