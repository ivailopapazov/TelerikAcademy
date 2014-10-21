namespace BullsAndCows.Web.Controllers
{
    using BullsAndCows.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ScoresController : BaseApiController
    {
        public ScoresController(IGameData data) 
            : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var result = this.data.UserDetails.All()
                .Select(ud => new
                {
                    Username = ud.User.UserName,
                    Rank = 100 * ud.Wins + 15 * ud.Losses
                })
                .OrderByDescending(r => r.Rank)
                .ThenBy(r => r.Username)
                .Take(10);

            return Ok(result);
        }
    }
}
