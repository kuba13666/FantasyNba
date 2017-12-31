using FantasyNba.ApiConsumer;
using FantasyNBA.ApiConsumer;
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

            return View();
        }
        public ActionResult GetPlayerDetails(int id)
        {
            return View(id);
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
                    PlayerApiID = player.player.ID,
                    LastName = player.player.LastName,
                    FirstName = player.player.FirstName,
                    JerseyNumber = player.player.JerseyNumber,
                    Position = player.player.Position,
                    Height = player.player.Height,
                    Weight = player.player.Weight,
                    BirthDate = player.player.BirthDate,
                    Age = player.player.Age,
                    BirthCity = player.player.BirthCity,
                    BirthCountry = player.player.BirthCountry,
                    IsRookie = player.player.IsRookie,
                    officialImageSrc = player.player.officialImageSrc
                };
                    _context.Players.Add(NewPlayer);
                }
                _context.SaveChanges();

                return RedirectToAction("GetPlayers", "Players");
            }

        }
    }