using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _2FreeHunger.EF.Models
{
    public class Enroll
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        //[Required]
        //public int VoterId { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [ForeignKey("Restaurant")]
        public int ResId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}