using FantasyNBA.ApiConsumer;
using FantasyNBA.Models;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IHttpActionResult> GetPlayers()
        {
            var client = new Client();
            var players = await client.GetAll();
            return Ok(players);

        }
        //Get /api/players/1
        public async Task<IHttpActionResult> GetPlayer(int id)
        {
            var client = new Client(id);
            var playerObject = await client.GetOne();
            if (playerObject == null)
            {
                return NotFound();
            }
            var playerEntry = playerObject.FirstOrDefault();
            return Ok(playerEntry);
        }
    }
}
