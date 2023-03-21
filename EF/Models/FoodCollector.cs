using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _2FreeHunger.EF.Models
{
    public class FoodCollector
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Destination { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [ForeignKey("Restaurant")]
        public int ResId { get; set; }

        [Required]
        public int Quantity { get; set; }
        

        public virtual Restaurant Restaurant { get; set; }
    }
}