using FantasyNBA.ApiConsumer;
using FantasyNBA.Models;
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
            var playerGameLog = await client.GetPlayerGameLog();
            var lastFiveGames = playerGameLog.gamelogs.OrderBy(g => g.game.date).Take(5).ToList();
            int _pts = 0;
            int _reb = 0;
            int _ast = 0;
            int _stl = 0;
            int _blk = 0;
            foreach (var log in lastFiveGames)
            {
                _pts += Convert.ToInt32(log.stats.Pts.text);
                _reb += Convert.ToInt32(log.stats.Reb.text);
                _ast += Convert.ToInt32(log.stats.Ast.text);
                _stl += Convert.ToInt32(log.stats.Stl.text);
                _blk += Convert.ToInt32(log.stats.Blk.text);
            }
            long _ptsPerGame = _pts / 5;
            long _rebPerGame = _reb / 5;
            long _astPerGame = _ast / 5;
            long _stlPerGame = _stl / 5;
            long _blkPerGame = _blk / 5;
            var statsWithGameLog = new StatsWithGameLogs()
            {
                statsEntry = playerStatsEntry,
                ptsPerGame = _ptsPerGame,
                rebPerGame = _rebPerGame,
                astPerGame = _astPerGame,
                stlPerGame = _stlPerGame,
                blkPerGame = _blkPerGame
            };
            //var _ptsPerGame = lastFiveGames.Sum(s => Convert.ToInt32(s.stats.Pts.text));
            return Ok(statsWithGameLog);
        }
    }
}
