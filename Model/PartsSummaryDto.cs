namespace PCParts.API.Model
{
    public class PartsSummaryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? Component { get; set; }
        public double Price { get; set; }
        public string? ThumbnailUrl { get; set; }
        public bool InStock { get; set; }


        public ICollection<PartDetailDTO> PartDetails { get; set; } = new List<PartDetailDTO>();
    }
}
