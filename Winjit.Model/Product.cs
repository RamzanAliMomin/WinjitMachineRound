using System;
using System.ComponentModel.DataAnnotations;

namespace Winjit.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Please Enter The Name")]
        public string Name { get; set; }

        public string Category { get; set; }

        public string Color { get; set; }

        [Required(ErrorMessage ="Please Enter The UnitPrice")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Please Enter The AvailableQuantity")]
        public int AvailableQuantity { get; set; }
    }
}
