using FantasyNba.ApiConsumer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FantasyNba.ApiConsumer
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

        private const string Url = "http://api.suredbits.com/nba/v0/players";
        private string Urlplayer;
        private const string Urlstats = "http://stats.nba.com/stats/playergamelog/?PlayerID=1628384&Season=2017-18&SeasonType=Regular%20Season";

        private string _json;
        public Client()
        {
            _client = new HttpClient();
        }
        public async Task<List<PlayersApi>> GetAll()
        {

            _httpResponse = await _client.GetAsync(Url);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<PlayersApi>>(_json);
        }
        public async Task<List<PlayersApi>> GetOne()
        {
            _httpResponse = await _client.GetAsync(Urlplayer);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<PlayersApi>>(_json);
        }
        public async Task<List<Stats>> GetStats()
        {
            _client.DefaultRequestHeaders.Add("Referer", "http://stats.nba.com/scores/");
            _httpResponse = await _client.GetAsync(Urlstats);
            _json = _httpResponse.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Stats>>(_json);
        }
    }
}