using System.ComponentModel.DataAnnotations;
namespace EagleVission.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Category { get; set; }

        [Required]
        [MaxLength(100)]
        public string BarCodeNo { get; set; }

        [Required]
        [MaxLength(200)]
        public decimal PurchasePrice { get; set; }

        [Required]
        [MaxLength(200)]
        public decimal SellPrice { get; set; }

        [MaxLength(100)]
        public decimal BulkPrice { get; set; }

        [MaxLength(100)]
        public string Stock { get; set; }

        [MaxLength(100)]
        public string? State { get; set; } // available or sold

        [MaxLength(200)]
        public string? Image { get; set; }

        [MaxLength(1000)]
        public string? Remarks { get; set; }

}
}
