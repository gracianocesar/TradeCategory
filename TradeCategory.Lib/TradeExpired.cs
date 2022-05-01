using TradeCategory.Lib.Model;

namespace TradeCategory.Lib
{
    public static class TradeExpired
    {
        public static Expired PerformTradeExpired(double value, string clientSector, DateTime nextPaymentData)
        {
            var tradeExpired = new Expired(value, clientSector, nextPaymentData)
            {
                Status = "EXPIRED"
            };
            return tradeExpired;
        }
    }
}
