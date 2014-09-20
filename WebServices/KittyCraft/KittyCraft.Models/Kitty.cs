namespace KittyCraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Kitty
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string Name { get; set; }

        [Range(0, 100)]
        public double Health { get; set; }

        public int? AirCraftId { get; set; }

        public virtual AirCraft AirCraft { get; set; }

        [Required]
        public KittyType KittyType { get; set; }
    }
}
