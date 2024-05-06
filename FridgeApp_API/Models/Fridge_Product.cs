using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FridgeApp_API.Models
{
    public class Fridge_Product
    {
        [Column("Fridge_ProductId")]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        [ForeignKey(nameof(Fridge))]
        public Guid FridgeId { get; set; }
        [Required(ErrorMessage = "Quantity of products are required field.")]
        public int Quantity {  get; set; }
    }
}
