using BullsAndCows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BullsAndCows.Web.Models
{
    public class GuessDataModel
    {
        public GuessDataModel(Guess guess)
	    {
            this.Id = guess.Id;
            this.UserId = guess.PlayerId;
            this.Username = guess.Player.UserName;
            this.GameId = guess.GameId;
            this.Number = guess.Number;
            this.DateMade = guess.DateMade;
            this.BullsCount = guess.BullsCount;
            this.CowsCount = guess.CowsCount;
	    }


        public int Id { get; set; }

        public string UserId { get; set; }

        public string Username { get; set; }

        public int GameId { get; set; }

        public string Number { get; set; }

        public DateTime DateMade { get; set; }

        public int CowsCount { get; set; }

        public int BullsCount { get; set; }
    }
}