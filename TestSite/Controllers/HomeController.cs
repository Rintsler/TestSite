using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using TestSite.Models;

namespace TestSite.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<UserAcc> _userManager;

        public HomeController(UserManager<UserAcc> usr)
        {
            _userManager = usr;
        }
        public async Task<IActionResult> Index()
        {
            UserAcc usr = await _userManager.GetUserAsync(HttpContext.User);
            
            var client = new RestClient("https://api.coindesk.com/v1");

            var request = new RestRequest("bpi/currentprice/rub.json", DataFormat.Json);
            var response = client.Get(request);

            var root = JsonConvert.DeserializeObject<Root>(response.Content);

            if (usr != null)
            {
                var fondInv = usr.fondInv;
            var valueInDataBase = Convert.ToInt32(fondInv);
            var btc = valueInDataBase / root.Rates.Rub.Rate;

            ViewBag.str = new string($"На дату: {root.Time.RateTime:G} - {valueInDataBase} руб = {btc} btc");
            }
            
            return View(usr);
        }
        
        class Root
        {
            public Time Time { get; set; }

            [JsonProperty("bpi")]
            public Rates Rates { get; set; }
        }

        class Time
        {
            [JsonProperty("updatedISO")]
            public DateTime RateTime { get; set; }
        }

        public class Rates
        {
            public RateInfo Usd { get; set; }

            public RateInfo Rub { get; set; }
        }

        public class RateInfo
        {
            public string Code { get; set; }

            public string Description { get; set; }

            [JsonProperty("rate_float")]
            public decimal Rate { get; set; }
        }
    }
}