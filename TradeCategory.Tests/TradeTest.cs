using System;
using TradeCategory.Lib.Model;
using Xunit;

namespace TradeCategory.Tests
{
    public class TradeTest
    {
        [Fact]
        public void ReturnTradePublicSector()
        {
            var trade = new Trade(1000, "Public", DateTime.Now);
            Assert.True("Public" == trade.ClientSector);
        }

        [Fact]
        public void ReturnTradePrivateSector()
        {
            var trade = new Trade(1000, "Private", DateTime.Now);
            Assert.True("Private" == trade.ClientSector);
        }

        [Fact]
        public void ReturnTradeValue()
        {
            var trade = new Trade(1000, "Private", DateTime.Now);
            Assert.True(trade.Value > 0);
        }

        [Fact]
        public void ReturnTradeValidDate()
        {
            var trade = new Trade(1000, "Private", DateTime.Now);
            Assert.True(trade.NextPaymentDate > DateTime.MinValue);
        }
    }
}
