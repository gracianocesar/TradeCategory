
using TradeCategory.Lib;
using TradeCategory.Lib.Model;

DateTime referenceDate = DateTime.MinValue;
double  value = 0;
string clientSector = string.Empty;
DateTime nextPaymentDate = DateTime.MinValue;
string trade;
string[] fomatedTrades;
int amount;
var listTrade = new List<Trade>();
var count = 0;

Console.WriteLine("Input a date for start trade. Ex:12/11/2020.");
referenceDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Input a amout of trade do you want to make. Ex: 4");
amount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < amount; i++)
{
    count = i + 1;
    Console.WriteLine("Input a trade {0}. Ex: 2000000 Private 12/29/2025",count);
    trade = Console.ReadLine();
    fomatedTrades = trade.Split(' ');

    if (fomatedTrades.Length == 3)
    {
        value = Convert.ToDouble(fomatedTrades[0]);
        clientSector = Convert.ToString(fomatedTrades[1]);
        nextPaymentDate = Convert.ToDateTime(fomatedTrades[2]);
    }
    listTrade.Add(PortifolioTrade.PerformPortifolioTrade(value,clientSector,nextPaymentDate,referenceDate));
}

foreach (var itemTrade in listTrade)
{
    Console.WriteLine(itemTrade.Status);
}