using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Produktnamn är obligatoriskt")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Namnet måste vara mellan 2 och 50 tecken")]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100000, ErrorMessage = "Priset måste vara mellan 0 och 100 000 kr")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Orderdatum")]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "Kategori måste anges")]
        public string Category { get; set; } = string.Empty; 

        public string Shelf { get; set; } = string.Empty;

        [Range(0, 1000, ErrorMessage = "Antalet måste vara mellan 0 och 1000")]
        [Display(Name = "Lagersaldo")]
        public int Count { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
