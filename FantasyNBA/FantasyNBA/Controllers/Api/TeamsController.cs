﻿using FantasyNBA.ApiConsumer;
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
    public class TeamsController : ApiController
    {
        private ApplicationDbContext _context;

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
            //var players = await client.GetAll();
            var teamPlayers = _context.TeamPlayers.Where(p => p.TeamId == id);
            //var players2 = players.Where(p=>playersIds.Contains(p.player.ID));
            foreach (var player in teamPlayers)
            {
                var playerGameLog = await client.GetPlayerGameLog(player.ExternalId);
                player.FirstName = playerGameLog.gamelogs[0].player.FirstName;
                player.LastName = playerGameLog.gamelogs[0].player.LastName;
                player.Pts = playerGameLog.gamelogs.Sum(g => Convert.ToInt32(g.stats.Pts));
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
