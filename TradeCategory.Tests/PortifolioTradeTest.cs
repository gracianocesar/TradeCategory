using System;
using System.Collections.Generic;
using System.Linq;
using TradeCategory.Lib;
using TradeCategory.Lib.Model;
using Xunit;

namespace TradeCategory.Tests
{
    public class PortifolioTradeTest
    {
        [Theory]
        [InlineData(2000000, "Public", "07/01/2020", "12/31/2022")]
        public void ReturnPotifolioExpirad(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var listTrade = new List<Trade>();
            listTrade.Add(new Trade(value, clientSector, nextPaymentData) { ReferenceDate = referenceDate });

            var _trade = PortifolioTrade.PerformPortifolioTrade(listTrade);
            Assert.True("EXPIRED".Equals(_trade.First()));
        }

        [Theory]
        [InlineData(2000000, "Private", "12/29/2025", "12/31/2022")]
        public void ReturnPotifolioHighRisk(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var listTrade = new List<Trade>();
            listTrade.Add(new Trade(value, clientSector, nextPaymentData) { ReferenceDate = referenceDate });

            var _trade = PortifolioTrade.PerformPortifolioTrade(listTrade);
            Assert.True("HIGHRISK".Equals(_trade.First()));
        }

        [Theory]
        [InlineData(2000000, "Public", "10/26/2023", "12/31/2022")]
        public void ReturnPotifolioMediumRisk(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var listTrade = new List<Trade>();
            listTrade.Add(new Trade(value, clientSector, nextPaymentData) { ReferenceDate = referenceDate });

            var _trade = PortifolioTrade.PerformPortifolioTrade(listTrade);
            Assert.True("MEDIUMRISK".Equals(_trade.First()));
        }
    }
}