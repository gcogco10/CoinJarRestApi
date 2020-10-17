using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoinJarRestAPI.Controllers;

namespace CoinJarRestAPI.Dependency_Injection
{
        public class CoinJar
        {
        private readonly Coins[] coins = Enum.GetValues(typeof(eCoinType)).Cast<eCoinType>().Select(t => new Coins(t)).ToArray();

        // default constructor.
        public CoinJar()
        {

        }

        public enum eCoinType
        {
            Cent = 1,
            Nickel = 5,
            Dime = 10,
            Quarter = 25,
            Half = 50,
            Large = 100
        }

        // creating some class object for memory allocation.
        public class Coins
        {
            public readonly eCoinType CoinType;

            public int Amount { get; set; } = 0;


            // constructor.
            public Coins(eCoinType coinType)
            {
                CoinType = coinType;
            }
        }
        // Add method.

        public void AddCoin(eCoinType coinType, int count = 1)
        {
            coins.First(t => t.CoinType == coinType).Amount += count;
        }

        // Get the total
        public decimal GetTotalAmount() => coins.Select(h => (decimal)h.CoinType * (decimal)h.Amount).Sum() / 100m;

        

        // Reset the amount to 0.
        public void Reset()
        {
            foreach(var h in coins)
            {
                h.Amount = 0;
            }
        }

        }
    
}