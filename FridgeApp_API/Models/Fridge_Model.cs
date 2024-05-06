using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FridgeApp_API.Models
{
    public class Fridge_Model
    {
        [Column("Fridge_ModelId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = " name is a required field.")]
        public string Name { get; set; } = string.Empty;
        public DateTime? Year { get; set; }
    }
}
