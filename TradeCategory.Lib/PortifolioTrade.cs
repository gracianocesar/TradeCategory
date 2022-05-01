using TradeCategory.Lib.Model;

namespace TradeCategory.Lib
{
    public static class PortifolioTrade
    {
        const double valueBase = 1000000;
        public static Trade PerformPortifolioTrade(double value, string clientSector, DateTime nextPaymentData, DateTime referenceDate)
        {
            var date = referenceDate.AddDays(30);
            if (nextPaymentData > date)
            {
                return TradeExpired.PerformTradeExpired(value, clientSector, nextPaymentData);
            }
            else if (value > valueBase && clientSector.Equals("Private"))
            {
                return TradeHighRisk.PerformTradeHigRisk(value, clientSector, nextPaymentData);
            }
            else if (value > valueBase && clientSector.Equals("Public"))
            {
                return TradeMediumRisk.PerformTradeMediumRisk(value, clientSector, nextPaymentData);
            }

            var tradeNotIplemented = new Trade(0, "", DateTime.MinValue) { ErrorMessage = "Not implemented Trade" };
            return tradeNotIplemented;
        }
    }
}
