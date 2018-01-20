using FantasyNBA.ApiConsumer;
using FantasyNBA.DateTimeExtension;
using FantasyNBA.Interfaces;
using FantasyNBA.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class TeamsController : ApiController
    {
        private ApplicationDbContext _context;
        private IRootObjectPlayerGameLog _gamelogs;

        public TeamsController(IRootObjectPlayerGameLog gamelogs)
        {
            _context = new ApplicationDbContext();
            _gamelogs = gamelogs;
        }
        public TeamsController()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<IHttpActionResult> GetTeamsPlayers(int id)
        {
            var team = _context.Teams.SingleOrDefault(x => x.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            var client = new Client();
            var teamPlayers = _context.TeamPlayers.Where(p => p.TeamId == id);
            var firstdayOfThisWeek = DateTime.Now.FirstDayOfWeek();
            //var playersGameLogs = await client.GetPlayerGameLog(date);
            foreach (var player in teamPlayers)
            {
                var playerGameLog = await client.GetPlayerGameLog(player.ExternalId);
                player.FirstName = playerGameLog.gamelogs[0].player.FirstName;
                player.LastName = playerGameLog.gamelogs[0].player.LastName;
                player.Pts = playerGameLog.gamelogs.Where(x => DateTime.Parse(x.game.date) >= firstdayOfThisWeek).Sum(g => Convert.ToInt32(g.stats.Pts.text));
                player.Reb = playerGameLog.gamelogs.Where(x => DateTime.Parse(x.game.date) >= firstdayOfThisWeek).Sum(g => Convert.ToInt32(g.stats.Reb.text));
                player.Ast = playerGameLog.gamelogs.Where(x => DateTime.Parse(x.game.date) >= firstdayOfThisWeek).Sum(g => Convert.ToInt32(g.stats.Ast.text));
                player.Stl = playerGameLog.gamelogs.Where(x => DateTime.Parse(x.game.date) >= firstdayOfThisWeek).Sum(g => Convert.ToInt32(g.stats.Stl.text));
                player.Blk = playerGameLog.gamelogs.Where(x => DateTime.Parse(x.game.date) >= firstdayOfThisWeek).Sum(g => Convert.ToInt32(g.stats.Blk.text));
                player.PlayerScore = player.Pts + player.Reb + player.Ast + player.Stl + player.Blk;
            }
            _context.SaveChanges();


            return Ok(teamPlayers);
        }



        [HttpPost]
        public IHttpActionResult CreateTeam(NewTeam newTeam)
        {
            var customer = _context.Customers.Single(c => c.Id == newTeam.CustomerId);

            var players = newTeam.PlayerIds;

            var team = new Team
            {
                name = newTeam.name,
                CustomerId = newTeam.CustomerId
            };
            _context.Teams.Add(team);
            _context.SaveChanges();

            foreach (var item in newTeam.PlayerIds)
            {
                var player = new TeamPlayer()
                {
                    ExternalId = item,
                    TeamId = team.Id
                };
                _context.TeamPlayers.Add(player);
            }


            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + team.Id), team);
        }

    }
}
