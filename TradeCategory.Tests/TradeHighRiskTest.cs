using System;
using TradeCategory.Lib;
using Xunit;

namespace TradeCategory.Tests
{
    public class TradeHighRiskTest
    {
        [Theory]
        [InlineData(2000000, "Private", "12/29/2025")]
        public void ReturnPotifolioHighRisk(double value, string clientSector, DateTime nextPaymentData)
        {
            var _trade = TradeHighRisk.PerformTradeHigRisk(value, clientSector, nextPaymentData);
            Assert.Equal("HIGHRISK", _trade.Status);
        }
    }
}
