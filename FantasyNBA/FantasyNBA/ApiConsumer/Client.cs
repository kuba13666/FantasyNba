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
        public Client(string lastName, string firstName)
        {
            _client = new HttpClient();
            Urlplayer = "http://api.suredbits.com/nba/v0/players/" + lastName +
"/" + firstName;
        }

        private HttpClient _client;
        private HttpResponseMessage _httpResponse;
        // Set referer property  to http://www.microsoft.com .

        private const string Url = "https://api.mysportsfeeds.com/v1.1/pull/nba/2017-2018-regular/active_players.json";
        private string Urlplayer;
        private const string Urlstats = "https://api.mysportsfeeds.com/v1.1/pull/nba/2017-2018-regular/player_gamelogs.json?team=bos";

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
        //public async Task<List<PlayersApi>> GetOne()
        //{
        //    _httpResponse = await _client.GetAsync(Urlplayer);
        //    _json = _httpResponse.Content.ReadAsStringAsync().Result;
        //    return JsonConvert.DeserializeObject<List<PlayersApi>>(_json);
        //}
        public async Task<RootObject> GetStats()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "a3ViYTEzNjphbndpbDE=");
            _httpResponse = await _client.GetAsync(Urlstats);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            var replacedJson = _json.Replace("@category", "category").Replace("@abbreviation", "abbreviation").Replace("#text", "text");
            return JsonConvert.DeserializeObject<RootObject>(replacedJson);

        }
    }
}