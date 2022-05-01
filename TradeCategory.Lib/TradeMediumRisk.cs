using TradeCategory.Lib.Model;

namespace TradeCategory.Lib
{
    public static class TradeMediumRisk
    {
        public static MediumRisk PerformTradeMediumRisk(double value, string clientSector, DateTime nextPaymentData) 
        {
            var tradeMeiumRisk = new MediumRisk(value, clientSector, nextPaymentData) 
            { 
                Status = "MEDIUMRISK"
            };
            return tradeMeiumRisk;
        }
    }
}
