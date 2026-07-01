using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Storage.Models
{
    public class ProductIndexViewModel
    {
        // Listan med produkter som ska visas i tabellen
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        // Listan som fyller dropdown-menyn med unika kategorier
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        // Håller reda på vad användaren sökte på (så det står kvar i rutan)
        public string SearchString { get; set; } = string.Empty;
        public string SelectedCategory { get; set; } = string.Empty;
    }
}