using FantasyNBA.Models;
using System.Linq;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class PlayersController : ApiController
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }
        //Get /api/players
        public IHttpActionResult GetPlayers()
        {
            var players = _context.Players.ToList();
            return Ok(players);

        }
        //Get /api/players/1
        public IHttpActionResult GetPlayer(int id)
        {
            var player = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}
