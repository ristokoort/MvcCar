using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCar.Models
{
    public class Car
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Color { get; set; }

        [Range(1, 300)]
        [Required]
        public int Speed { get; set; }

        [StringLength(3)]
        [Required]
        public string Condition { get; set; }
    }
}
