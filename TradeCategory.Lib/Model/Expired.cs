namespace TradeCategory.Lib.Model
{
    public class Expired : Trade
    {
        public Expired(double value, string clientSector, DateTime nextPaymentData) 
            : base(value, clientSector, nextPaymentData)
        {
           
        }       
    }
}
