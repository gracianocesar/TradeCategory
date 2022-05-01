namespace TradeCategory.Lib.Model
{
    public class MediumRisk : Trade
    {
        public MediumRisk(double value, string clientSector, DateTime nextPaymentData) 
            : base(value, clientSector, nextPaymentData)
        {
        }
    }
}
