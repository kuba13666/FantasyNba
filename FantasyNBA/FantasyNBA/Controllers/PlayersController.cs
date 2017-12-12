using FantasyNba.ApiConsumer;
using FantasyNBA.Models;
using FantasyNBA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FantasyNBA.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Players

        public ActionResult GetPlayers()
        {

            var players = _context.Players.Include(p => p.Position).ToList();
            return View(players);
        }
        public ActionResult GetPlayerDetails(int id)
        {
            var players = _context.Players.Include(p => p.Position).SingleOrDefault(c => c.Id == id);
            if (players == null)
                return HttpNotFound();

            return View(players);
        }

        public async Task<ActionResult> DownloadPlayerList()
        {
            var client = new Client();
            var players = await client.GetAll();
            Random rnd = new Random();
            foreach (var player in players)
            {
                var NewPlayer = new Player
                {
                    LastYear = player.lastYear,
                    RookieYear = player.rookieYear,
                    FullName = player.fullName,
                    LastName = player.lastName,
                    FirstName = player.FirstName,
                    BirthDate = player.birthDate,
                    ProfileUrl = player.profileUrl,
                    Status = player.status,
                    RealTeam = player.team,
                    PositionId = rnd.Next(1, 5)
                };
                _context.Players.Add(NewPlayer);
            }
            _context.SaveChanges();

            return RedirectToAction("GetPlayers", "Players");
        }

        public async Task<ActionResult> GetStatistics()
        {
            var client = new Client();
            var models = await client.GetStats();
            var model = models.FirstOrDefault();
            return View(models);
        }
    }
}