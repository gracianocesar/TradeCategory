using TradeCategory.Lib.Interface;

namespace TradeCategory.Lib.Model
{
    public class NotCategorized : ICategory
    {
        public string Name { get => "NOT CATEGORIZED";} 

        public bool AppliesTo(Trade trade)
        {
            return true;
        }
    }
}
