using FantasyNba.ApiConsumer.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using FantasyNBA.Models;

namespace FantasyNBA.ApiConsumer
{
    public class Client
    {
        public Client(int player)
        {
            _client = new HttpClient();
            UrlPlayer = "https://api.mysportsfeeds.com/v1.1/pull/nba/2017-2018-regular/active_players.json?player=" + player;
            UrlPlayerStats = "https://api.mysportsfeeds.com/v1.1/pull/nba/2017-2018-regular/cumulative_player_stats.json?player=" + player;
        }

        private HttpClient _client;
        private HttpResponseMessage _httpResponse;
        // Set referer property  to http://www.microsoft.com .

        private const string Url = "https://api.mysportsfeeds.com/v1.1/pull/nba/2017-2018-regular/active_players.json";
        private string UrlPlayer;
        private string UrlPlayerStats;

        private string _json;
        public Client()
        {
            _client = new HttpClient();
        }
        public async Task<List<Playerentry>> GetAll()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "a3ViYTEzNjphbndpbDE=");
            _httpResponse = await _client.GetAsync(Url);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            return (List<Playerentry>)(JsonConvert.DeserializeObject<RootObjectPlayers>(_json).activeplayers.playerentry);
        }
        public async Task<List<Playerentry>> GetOne()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "a3ViYTEzNjphbndpbDE=");
            _httpResponse = await _client.GetAsync(UrlPlayer);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            return (List<Playerentry>)(JsonConvert.DeserializeObject<RootObjectPlayers>(_json).activeplayers.playerentry);
        }
        public async Task<List<Playerstatsentry>> GetPlayerStats()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "a3ViYTEzNjphbndpbDE=");
            _httpResponse = await _client.GetAsync(UrlPlayerStats);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            var replacedJson = _json.Replace("@category", "category").Replace("@abbreviation", "abbreviation").Replace("#text", "text");
            return (List<Playerstatsentry>)(JsonConvert.DeserializeObject<RootObjectStats>(replacedJson).cumulativeplayerstats.playerstatsentry);
        }

    }
}