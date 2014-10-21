namespace BullsAndCows.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using BullsAndCows.Models;

    public class ResponseGameDataModel
    {
        public static Expression<Func<Game, ResponseGameDataModel>> FromGame
        { 
            get
            {
                return g => new ResponseGameDataModel
                    {
                        Id = g.Id,
                        Name = g.Name,
                        Blue = "No blue player yet",
                        Red = g.RedPlayer.UserName,
                        GameState = g.GameState,
                        DateOfCreation = g.DateOfCreation
                    };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Red { get; set; }

        public string Blue { get; set; }

        public GameState GameState { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}