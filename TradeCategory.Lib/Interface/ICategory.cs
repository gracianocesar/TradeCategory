using TradeCategory.Lib.Model;

namespace TradeCategory.Lib.Interface
{
    public interface ICategory
    {
        public string Name { get; }
        public bool AppliesTo(Trade trade);
    }

}
