using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tuan2.Models
{
    public class Product
    {
        [Required, StringLength(50)]
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }


        [Required, StringLength(100)]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [Required, StringLength(50)]
        [DisplayName("Giá bán")]
        [Range(1000.00, 10000000.00)]
        public decimal Price { get; set; }

        [Required, StringLength(50)]
        [DisplayName("Mô tả sản phẩm")]
        public string Description { get; set; }

        [Required, StringLength(50)]
        [DisplayName("Mã loại sản phẩm")]
        public int CategoryId { get; set; }

        public string? ImageUrl { get; set; }
        public List<string>? ImageUrls { get; set; }
    }
}
