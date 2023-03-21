using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2FreeHunger.EF.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
       
        public int TotalDonation { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }    
        public virtual ICollection<FoodCollector> FoodCollectors { get; set;}

        public Restaurant()
        {
            Enrolls= new List<Enroll>();
            FoodCollectors= new List<FoodCollector>();
        }

    }
}