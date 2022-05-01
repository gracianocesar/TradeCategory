namespace TradeCategory.Lib.Interface
{
    public interface ITrade
    {
        double Value { get;  }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
        Guid? TrasactionNumber { get; }
        //bool IsPoliticallyExposed { get; }
    }
}
