using System;
using TradeCategory.Lib;
using Xunit;

namespace TradeCategory.Tests
{
    public class TradeMediumRiskTest
    {
        [Theory]
        [InlineData(2000000, "Public", "12/29/2025")]
        public void ReturnPotifolioMediumRisk(double value, string clientSector, DateTime nextPaymentData)
        {
            var _trade = TradeMediumRisk.PerformTradeMediumRisk(value, clientSector, nextPaymentData);
            Assert.Equal("MEDIUMRISK", _trade.Status);
        }
    }
}
