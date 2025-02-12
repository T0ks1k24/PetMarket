namespace Backend.Data.Models
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; }
        public string ImageUrl {  get; set; } = string.Empty;

        public string CaaId { get; set; }
    }
}
