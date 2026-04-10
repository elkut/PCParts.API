namespace PCParts.API.Model
{
    public class PartDetailDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public double? LowestPriceInLast30Days { get; set; }
        public string? Description { get; set; }
        public string[]? ImageUrls { get; set; }

    }
}
