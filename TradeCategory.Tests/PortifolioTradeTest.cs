using System;
using TradeCategory.Lib;
using Xunit;

namespace TradeCategory.Tests
{
    public class PortifolioTradeTest
    {
        [Theory]
        [InlineData(2000000,"Private", "12/29/2025","12/11/2022")]
        public void ReturnPotifolioExpirad(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var _trade = PortifolioTrade.PerformPortifolioTrade(value, clientSector, nextPaymentData, referenceDate);
            Assert.Equal("EXPIRED", _trade.Status);
        }

        [Theory]
        [InlineData(2000000, "Private", "12/29/2025", "12/11/2025")]
        public void ReturnPotifolioHighRisk(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var _trade = PortifolioTrade.PerformPortifolioTrade(value, clientSector, nextPaymentData, referenceDate);
            Assert.Equal("HIGHRISK", _trade.Status);
        }


        [Theory]
        [InlineData(2000000, "Public", "12/29/2025", "12/11/2025")]
        public void ReturnPotifolioMediumRisk(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var _trade = PortifolioTrade.PerformPortifolioTrade(value, clientSector, nextPaymentData, referenceDate);
            Assert.Equal("MEDIUMRISK", _trade.Status);
        }
    }
}