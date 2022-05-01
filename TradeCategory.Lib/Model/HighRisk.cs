namespace TradeCategory.Lib.Model
{
    public class HighRisk : Trade
    {
        public HighRisk(double value, string clientSector, DateTime nextPaymentData) 
            : base(value, clientSector, nextPaymentData)
        {
        }
    }
}
