namespace BullsAndCows.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;

    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using BullsAndCows.Web.Models;

    public class GuessesController : BaseApiController
    {
        public GuessesController(IGameData data) 
            : base(data)
        {
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult MakeGuess(int id, RequestNumberDataModel numberModel)
        {
            // Check if the game is in playing mode
            var game = this.data.Games.Find(id);
            if (game.GameState == GameState.WaitingForOpponent)
            {
                return BadRequest("Cannot make guess for this game!");
            }

            // Check if user is not in the game
            string currentUserId = this.User.Identity.GetUserId();
            if (game.RedPlayerId != currentUserId && game.BluePlayerId != currentUserId)
            {
                return BadRequest("Cannot make guess for a game that you're not currently in!");
            }

            // Check if user has the right to make the turn
            if ((game.GameState == GameState.RedInTurn && game.RedPlayerId != currentUserId) ||
                game.GameState == GameState.BlueInTurn && game.BluePlayerId != currentUserId)
            {
                return BadRequest("You must wait your turn to make a guess!");
            }

            string currentNumberToGess;
            if (game.RedPlayerId == currentUserId)
            {
                currentNumberToGess = game.RedNumber;
            }
            else
            {
                currentNumberToGess = game.BlueNumber;

            }

            // Check number
            var guess = CheckNumber(currentNumberToGess, new Guess { Number = numberModel.Number });

            // Check if user guesses the right number
            if (guess.BullsCount == 4)
            {
                // Game is finished
                game.GameState = GameState.Finished;

                // apply score to both users
                ApplicationUser winner;
                ApplicationUser loser;
                if (game.RedPlayerId == currentUserId)
                {
                    winner = game.RedPlayer;
                    loser = game.BluePlayer;
                }
                else
                {
                    winner = game.BluePlayer;
                    loser = game.RedPlayer;
                }

                UserDetail winnerUserDetail = this.data.UserDetails.All().FirstOrDefault(ud => ud.UserId == winner.Id);
                if (winnerUserDetail == null)
                {
                    winnerUserDetail = new UserDetail
                    {
                        UserId = winner.Id,
                        Losses = 0,
                        Wins = 0,
                    };

                    this.data.UserDetails.Add(winnerUserDetail);
                }

                UserDetail loserUserDetail = this.data.UserDetails.All().FirstOrDefault(ud => ud.UserId == loser.Id);
                if (loserUserDetail == null)
                {
                    loserUserDetail = new UserDetail
                    {
                        UserId = loser.Id,
                        Losses = 0,
                        Wins = 0,
                    };

                    this.data.UserDetails.Add(loserUserDetail);
                }

                winnerUserDetail.Wins++;
                loserUserDetail.Losses++;
                this.data.SaveChanges();


                // players recieves notification
            }
            else
            {
                if (game.GameState == GameState.RedInTurn)
                {
                    // Send notification
                    game.GameState = GameState.BlueInTurn;
                }
                else
                {
                    game.GameState = GameState.RedInTurn;
                }
            }

            guess.DateMade = DateTime.Now;
            guess.GameId = game.Id;
            guess.Player = this.data.Users.Find(currentUserId);
            guess.PlayerId = currentUserId;

            this.data.Guesses.Add(guess);
            this.data.SaveChanges();

            GuessDataModel result = new GuessDataModel(guess);

            return Ok(result);
        }

        private Guess CheckNumber(string number, Guess guess)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].Equals(guess.Number[i]))
                {
                    guess.BullsCount++;
                    continue;
                }

                for (int j = 0; j < guess.Number.Length; j++)
                {
                    if (number[i].Equals(guess.Number[j]))
                    {
                        guess.CowsCount++;
                        break;
                    }
                }
            }

            return guess;
        }
    }
}
