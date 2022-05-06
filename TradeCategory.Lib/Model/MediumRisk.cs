using TradeCategory.Lib.Interface;

namespace TradeCategory.Lib.Model
{
    public class MediumRisk : ICategory
    {
        public string Name { get => "MEDIUMRISK"; }

        public bool AppliesTo(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector.Equals("Public"));
        }
    }
}
