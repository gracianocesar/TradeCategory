using TradeCategory.Lib.Interface;

namespace TradeCategory.Lib.Model
{
    public class Expired : ICategory
    {
        public string Name { get => "EXPIRED"; }

        public bool AppliesTo(Trade trade)
        {
            return (trade.ReferenceDate.AddDays(30) > trade.NextPaymentDate);
        }
    }
}
