using TradeCategory.Lib.Interface;

namespace TradeCategory.Lib.Model
{
    public class HighRisk : ICategory
    {
        public string Name { get => "HIGHRISK"; }

        public bool AppliesTo(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector.Equals("Private"));
        }
    }
}
