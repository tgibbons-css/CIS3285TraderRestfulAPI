using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeDataController : ControllerBase
    {
        List<string> tradeList = new List<string>();

        public TradeDataController()
        {
            // Put trade strings into list of strings 
            tradeList.Add("GBPUSD,10000,2.25");
            tradeList.Add("GBPJPY,50000,178.00");
            tradeList.Add("USDEUR,2000,0.90");
        }

        // GET: api/<TradeDataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { "GBPUSD,1000,1.51", , "USDEUR,1200,0.86" };
            return tradeList;

        }

        // GET api/<TradeDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return tradeList[id];
        }

    }
}
