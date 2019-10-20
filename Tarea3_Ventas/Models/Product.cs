using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3_Ventas.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }
        [DisplayName("List price")]
        public double ListPrice { get; set; }
        [DisplayName("Standard Cost")]
        public double StandardCost { get; set; }
        public string Category { get; set; }

    }
}
