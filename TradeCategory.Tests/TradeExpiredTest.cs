using System;
using TradeCategory.Lib;
using Xunit;

namespace TradeCategory.Tests
{
    public class TradeExpiredTest
    {
        [Theory]
        [InlineData(2000000, "Private", "12/29/2025")]
        public void ReturnTradeExpirad(double value, string clientSector, DateTime nextPaymentData)
        {
            var _trade = TradeExpired.PerformTradeExpired(value, clientSector, nextPaymentData);
            Assert.Equal("EXPIRED", _trade.Status);
        }
    }
}
