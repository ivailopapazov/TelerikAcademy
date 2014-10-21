namespace BullsAndCows.Web.Models
{
    using System;
    using System.Linq;
    using BullsAndCows.Models;
    using System.ComponentModel.DataAnnotations;

    public class RequestGameDataModel
    {
        public string Name { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string Number { get; set; }

    }
}