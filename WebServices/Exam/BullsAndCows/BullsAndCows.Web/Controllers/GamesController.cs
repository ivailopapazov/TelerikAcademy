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
    using BullsAndCows.Web.Models;
    using BullsAndCows.Models;

    public class GamesController : BaseApiController
    {
        private const int ResultPerPage = 10;

        public GamesController(IGameData data) 
            : base(data)
        {
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(RequestGameDataModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentUserId = this.User.Identity.GetUserId();

            var game  = new Game
            {
                Name = model.Name,
                RedPlayerId = currentUserId,
                RedNumber = model.Number,
                DateOfCreation = DateTime.Now,
                GameState = GameState.WaitingForOpponent,
            };

            this.data.Games.Add(game);
            this.data.SaveChanges();

            ResponseGameDataModel response = new ResponseGameDataModel
            {
                Id = game.Id,
                Name = game.Name,
                Blue = "No blue player yet",
                Red = data.Users.Find(currentUserId).Email,
                GameState = GameState.WaitingForOpponent,
                DateOfCreation = game.DateOfCreation,
            };

            return Ok(response);   
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            return this.All(0);
        }

        [HttpGet]
        public IHttpActionResult All(int page)
        {
            string currentUserId;
            var games = this.data.Games.All().AsQueryable();
            if (this.User.Identity.IsAuthenticated)
            {
                currentUserId = this.User.Identity.GetUserId();
                games = games.Where(g =>
                    g.GameState == GameState.WaitingForOpponent ||
                    g.BluePlayerId == currentUserId ||
                    g.RedPlayerId == currentUserId);
            }
            else
            {
                games = games.Where(g => g.GameState == GameState.WaitingForOpponent);
            }

            var result = games.OrderBy(g => g.Name)
                .ThenBy(g => g.DateOfCreation)
                .ThenBy(g => g.RedPlayer.UserName)
                .Skip(ResultPerPage * page)
                .Take(ResultPerPage)
                .Select(ResponseGameDataModel.FromGame)
                .ToArray();

            return Ok(result);
        }


        [Authorize]
        [HttpGet]
        public  IHttpActionResult Details(int id)
        {
            //Get details and guesses in array
            string currentUserId = this.User.Identity.GetUserId();
            var game = this.data.Games.Find(id);
            if (game.BluePlayerId != currentUserId && game.RedPlayerId != currentUserId)
            {
                return BadRequest("It's not your game!");
            }

            if (game.GameState != GameState.RedInTurn && game.GameState != GameState.BlueInTurn)
            {
                return BadRequest("The game is not in play state!");
            }

            var result = new GameDetailsDataModel
            {
                Id = game.Id,
                Name = game.Name,
                DateCreated = game.DateOfCreation,
                Red = game.RedPlayer.UserName,
                Blue = game.BluePlayer.UserName,
                YourNumber = game.RedPlayerId == currentUserId ? game.RedNumber : game.BlueNumber,
                YourGuesses = game.Guesses
                    .Where(g => g.PlayerId == currentUserId)
                    .Select(g => new GuessDataModel(g))
                    .ToArray()
            };

            return Ok(result);
        }

        [Authorize]
        [HttpPut]
        public IHttpActionResult Join(int id, RequestGameDataModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Validate if user is the same
            string currentUserId = this.User.Identity.GetUserId();
            var game = this.data.Games.Find(id);
            if (game.RedPlayerId == currentUserId)
            {
                return BadRequest("Cannot join your own game!");
            }

            // Red player recieves a notification


            // Decide first
            GameState initialState;
            Random random = new Random();
            if (random.Next(0, 100) < 50)
            {
                initialState = GameState.RedInTurn;
            }
            else
            {
                initialState = GameState.BlueInTurn;
            }

            // First player recieves notification


            // Change game state
            game.GameState = initialState;
            game.BluePlayerId = currentUserId;
            game.BlueNumber = model.Number;
            this.data.SaveChanges();

            return Ok(new { Result = string.Format("You joined game \"{0}\"", game.Name) });
        }
    }
}

