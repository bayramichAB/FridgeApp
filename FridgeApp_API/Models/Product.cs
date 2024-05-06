using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FridgeApp_API.Models
{
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name field is  required.")]
        public string Name { get; set; } = string.Empty;
        public int? Default_Quantity { get; set; }
    }
}
