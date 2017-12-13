using FantasyNBA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class TeamsController : ApiController
    {
        private ApplicationDbContext _context;

        public TeamsController()
        {
            _context = new ApplicationDbContext();
        }


        public IHttpActionResult GetTeamsPlayers(int id)
        {
            var team = _context.Teams.SingleOrDefault(x => x.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            var players = _context.Players.Include(path=>path.Position).Where(x => x.TeamId == team.Id);
            return Ok(players);
        }



        [HttpPost]
        public IHttpActionResult CreateTeam(NewTeam newTeam)
        {
            var customer = _context.Customers.Single(c => c.Id == newTeam.CustomerId);
            
            var players = _context.Players.Where(p => newTeam.PlayerIds.Contains(p.Id)).ToList();

            var team = new Team
            {
                name = newTeam.name,
                Players = players,
                CustomerId = newTeam.CustomerId
            };
            
            foreach (var player in players)
            {
                if (player.TeamId!=null)
                    return BadRequest("Player already assigned");
                
                player.TeamId = team.Id;
                _context.Entry(player).State = EntityState.Modified;
            }
            _context.Teams.Add(team);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + team.Id), team);
        }

    }
}
