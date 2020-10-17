using CoinJarRestAPI.Dependency_Injection;
using CoinJarRestAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static CoinJarRestAPI.Dependency_Injection.CoinJar;

namespace CoinJarRestAPI.Controllers
{
    
    [Route("[CoinJarController]")]
    public class CoinJarController : ApiController
    {

        
        private readonly CoinJar coinJar;

        public CoinJarController(CoinJar coinJar, Coins coins)
        {
            
            this.coinJar = coinJar;
        }

        // default constructor.
        public CoinJarController()
        {

        }
        [HttpPost]
         public void AddCoin([FromBody]eCoinType coinType, [FromBody]int count = 1)
        {
            
            this.coinJar.AddCoin(coinType, count);
        }
        [HttpGet]
        public decimal Amount([FromBody] double amount)
        {
            return this.coinJar.GetTotalAmount();
        }
        [HttpPut]
        public void Reset()
        {
            this.coinJar.Reset();
            
        }
    }

    
}