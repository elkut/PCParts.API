namespace PCParts.API.Model
{
    public class PartsSummaryDto
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? brand { get; set; }
        public string? category { get; set; }
        public double price { get; set; }
        public long thumbnailUrl { get; set; }
        public bool inStock { get; set; }

    }
}
