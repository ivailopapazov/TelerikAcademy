namespace KittyCraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AirCraft
    {
        private ICollection<Kitty> kittys;

        public AirCraft()
        {
            this.kittys = new HashSet<Kitty>();
        }
        
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Model { get; set; }

        public ICollection<Kitty> Kittys
        {
            get { return kittys; }
            set { kittys = value; }
        }
        
    }
}
