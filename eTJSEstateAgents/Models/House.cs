using System.ComponentModel.DataAnnotations;

namespace eTJSEstateAgents.Models
{
    public class House
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Owner's Name")]
        [DataType(DataType.Text)]
        public string? OwnerName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Property Name")]
        [DataType(DataType.Text)]
        public string? MyProperty { get; set; }

        [Required]
        [Display(Name = "Property Value")]
        [DataType(DataType.Currency)]
        public int PropertyValue { get; set; }
    }
}
