using System.ComponentModel.DataAnnotations;

namespace EagleVission.Models
{
    public class ProductModel
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string companyName { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string barCodeNo { get; set; }

        [Required]
        public decimal purchasePrice { get; set; }

        [Required]
        public decimal sellPrice { get; set; }

        public decimal? bulkPrice { get; set; }

        public string? stock { get; set; }

        public string? state { get; set; } // available or sold

        public string? image { get; set; }

        public string? remarks { get; set; }
    }
}
