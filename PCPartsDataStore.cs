using PCParts.API.Models;

namespace PCParts.API
{
    public class PCPartsDataStore
    {
        public List<PartsSummaryDto> PCParts { get; set; }
        public ICollection<PartDetailDTO> PCPartDetails { get; set; } = new List<PartDetailDTO>();
        public static PCPartsDataStore Parts { get; } = new PCPartsDataStore();

        // Constructor to initialize the data store with sample data
        // In a real application, this data would likely come from a database or an external API
        // For demonstration purposes, we are hardcoding some sample PC parts data
        public PCPartsDataStore()
        {
            PCParts = new List<PartsSummaryDto>
            {
                new PartsSummaryDto()
                {
                    Id = 1,
                    Name = "NVIDIA GeForce RTX 4090",
                    Brand = "NVIDIA",
                    Component = "GPU",
                    Price = 599.99,
                    ThumbnailUrl = "https://example.com/images/rtx4090.jpg",
                    InStock = true,
                    PartDetails = new List<PartDetailDTO>()
                    {
                        new PartDetailDTO()
                        {
                            Id = 1,
                            Name = "NVIDIA GeForce RTX 4090",
                            Price = 599.99,
                            Brand = "NVIDIA",
                            Component = "GPU",
                            Description = "The NVIDIA GeForce RTX 4090 is a high-end graphics card designed for gaming and professional workloads. It features advanced ray tracing capabilities, AI-powered features, and exceptional performance for demanding applications.",
                            ImageUrls = new string[]
                            {
                                "https://example.com/images/rtx4090_1.jpg",
                                "https://example.com/images/rtx4090_2.jpg"
                            },
                            Details = new string[]
                            {
                                "CUDA Cores: 10496",
                                "Base Clock: 1.5 GHz",
                                "Boost Clock: 1.8 GHz",
                                "Memory: 24 GB GDDR6X",
                                "Memory Interface: 384-bit"
                            },
                            AdditionalInfo = "Requires a minimum of a 750W power supply.",
                            InStock = true
                        }
                    }
                },
                new PartsSummaryDto()
                {
                    Id = 2,
                    Name = "AMD Ryzen 9 5950X",
                    Brand = "AMD",
                    Component = "CPU",
                    Price = 799.99,
                    ThumbnailUrl = "https://example.com/images/ryzen5950x.jpg",
                    InStock = false,

                    PartDetails = new List<PartDetailDTO>()
                    {
                        new PartDetailDTO()
                        {
                            Id = 2,
                            Name = "AMD Ryzen 9 5950X",
                            Brand = "AMD",
                            Component = "CPU",
                            Price = 799.99,
                            ImageUrls = new string[]
                            {
                                "https://example.com/images/ryzen5950x.jpg",
                                "https://example.com/images/ryzen5950x_2.jpg",
                                "https://example.com/images/ryzen5950x_3.jpg"
                            },
                            Details = new string[]
                            {
                                "Cores: 16",
                                "Threads: 32",
                                "Base Clock: 3.4 GHz",
                                "Boost Clock: 4.9 GHz",
                                "Cache: 72 MB"
                            },
                            AdditionalInfo = "Compatible with AM4 socket motherboards.",
                            InStock = false,
                        }
                    }

                } // Add more parts as needed
            }; // End of PCParts initialization
        }// End of constructor
    }// End of PCPartsDataStore class
}// End of namespace
