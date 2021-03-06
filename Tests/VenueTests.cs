﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stockfighter;
using System.Threading.Tasks;

namespace Tests
{
    // Note that these tests assume that Stockfighter's test exchange is up and functionning as expected.

    [TestClass]
    public class VenueTests
    {
        [TestMethod]
        public async Task CanGetVenueHeartbeat()
        {
            var venue = new Venue(Config.Venue);
            var isUp = await venue.IsUp();

            Assert.IsTrue(isUp);
        }

        [TestMethod]
        public async Task CanGetVenueStocks()
        {
            var venue = new Venue(Config.Venue);
            var stocks = await venue.GetStocks();

            Assert.AreEqual(Config.Stock, stocks[0].Symbol);
        }
    }
}
