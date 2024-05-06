using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FridgeApp_API.Models
{
    public class Fridge
    {
        [Column("FridgeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Fridge name is a required field.")]
        public string Name { get; set; } = string.Empty;
        public string? OwnerName { get; set; }

        public Fridge_Model? Model {get;set;}
        [ForeignKey(nameof(Fridge_Model))]
        public Guid Fridge_ModelId { get; set; }
    }
}
