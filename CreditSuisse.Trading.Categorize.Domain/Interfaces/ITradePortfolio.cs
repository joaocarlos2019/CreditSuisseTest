using CreditSuisse.Trading.Categorize.Domain.Interfaces;

namespace CreditSuisse.Trading.Categorize.Domain
{
    public interface ITradePortfolio
    {
        public DateTime ReferenceDate { get; set; }

        public int NumberTradesOfPortFolio { get; set; }

        public List<ITrade> Trades {get;set;}


    }
}
