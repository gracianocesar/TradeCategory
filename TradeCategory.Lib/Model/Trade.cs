using TradeCategory.Lib.Interface;

namespace TradeCategory.Lib.Model
{
    public class Trade : ITrade
    {
        private readonly double _value;
        private readonly string _clientSector;
        private readonly DateTime _nextPaymentDate;

        public int Amount { get; set; }
        public DateTime ReferenceDate { get; set; }
        //private bool _isPoliticallyExposed {get;set;}

        public string ErrorMessage { get; set; }
        public string Status { get; set; }

        public Trade(double value, string clientSector, DateTime nextPaymentData)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentData;
        }

        public double Value { get => _value; }

        public string ClientSector { get => _clientSector; }

        public DateTime NextPaymentDate { get => _nextPaymentDate; }

        //public bool IsPoliticallyExposed { get => _isPoliticallyExposed; }

    }
}
