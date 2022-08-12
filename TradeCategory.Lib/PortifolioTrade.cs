using TradeCategory.Lib.Interface;
using TradeCategory.Lib.Model;

namespace TradeCategory.Lib
{
    public static class PortifolioTrade
    {
        public static List<string> PerformPortifolioTrade(List<Trade> trades)
        {
            var listCategory = new List<ICategory>();

            listCategory.Add(new Expired());
            listCategory.Add(new HighRisk());
            listCategory.Add(new MediumRisk());
            listCategory.Add(new NotCategorized());

            var listCategoryReturn = new List<string>();

            foreach (var trade in trades)
            {
                foreach (var category in listCategory)
                {
                    if (category.AppliesTo(trade))
                    {
                        listCategoryReturn.Add(category.Name);
                        break;
                    }
                }
                
            }
            return listCategoryReturn;
        }
    }
}
