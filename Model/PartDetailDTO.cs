namespace PCParts.API.Model
{
    public class PartDetailDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Brand { get; set; }
        public string? Component { get; set; }
        public string? Description { get; set; }
        public string[]? ImageUrls { get; set; }
        public string[]? Details { get; set; }
        public string? AdditionalInfo { get; set; }

    }
}
