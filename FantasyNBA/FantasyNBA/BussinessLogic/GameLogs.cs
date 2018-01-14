using FantasyNBA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyNba.ApiConsumer.Models;
using FantasyNBA.ApiConsumer;
using FantasyNBA.DateTimeExtension;

namespace FantasyNBA.BussinessLogic
{
    public class GameLogs : IRootObjectPlayerGameLog
    {
        public Playergamelogs playergamelogs
        {
            get;
            set;
        }
        public GameLogs()
        {
            var client = new Client();
            var firstdayOfThisWeek = DateTime.Now.FirstDayOfWeek();
            string date = firstdayOfThisWeek.ToString("yyyyMMdd");
            playergamelogs = client.GetPlayerGameLog(date).Result;
        }
    }
}