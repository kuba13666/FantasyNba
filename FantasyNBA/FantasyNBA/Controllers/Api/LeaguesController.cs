using FantasyNBA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class LeaguesController : ApiController
    {
        private ApplicationDbContext _context;
        public LeaguesController()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<IHttpActionResult> GetLeaguesTeams(int id)
        {
            var teams = _context.Teams.Include(tp=>tp.TeamPlayers).Where(l=>l.League.Id==id);
            if (teams == null)
            {
                return NotFound();
            }
            foreach (var team in teams)
            {
                team.Score = team.TeamPlayers.Sum(s=>s.PlayerScore);
            }
            _context.SaveChanges();


            return Ok(teams);
        }
    }
}
