using CreditSuisse.Trading.Categorize.Domain.Interfaces;
using System.Diagnostics;

namespace CreditSuisse.Trading.Categorize.Domain
{
    public class Trade : ITrade
    {
        public double Value { get; set ; }
        public string ClientSector { get ; set ; }
        public DateTime NextPaymentDate { get ; set ; }
        public bool IsPoliticallyExposed { get; set ; }

        public bool isExpired()
        {
            return NextPaymentDate.Date < DateTime.Now.AddDays(30);
        }

        public bool isHighRisk()
        {
            return Value > 1000000 && ClientSector.Equals("Private");
        }

        public bool isMediumRisk()
        {
            return Value > 1000000 && ClientSector.Equals("Public");
        }
    }
}
