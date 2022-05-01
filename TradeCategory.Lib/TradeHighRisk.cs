using TradeCategory.Lib.Model;

namespace TradeCategory.Lib
{
    public static class TradeHighRisk
    {
        public static HighRisk PerformTradeHigRisk(double value, string clientSector, DateTime nextPaymentData) 
        {
            var tradeHigRisk = new HighRisk(value, clientSector, nextPaymentData)
            {
                Status = "HIGHRISK"
            };
            return tradeHigRisk;        
        }
    }
}
