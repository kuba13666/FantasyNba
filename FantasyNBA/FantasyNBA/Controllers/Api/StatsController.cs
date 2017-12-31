using FantasyNBA.ApiConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class StatsController : ApiController
    {
        public async Task<IHttpActionResult> GetPlayerStats(int id)
        {
            var client = new Client(id);
            var playerStatsObject = await client.GetPlayerStats();
            if (playerStatsObject == null)
            {
                return NotFound();
            }
            var playerStatsEntry = playerStatsObject.FirstOrDefault();
            return Ok(playerStatsEntry);
        }
    }
}
