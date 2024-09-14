
using CreditSuisse.Trading.Categorize.Domain.Interfaces;

namespace CreditSuisse.Trading.Categorize.Domain
{
    public class TradePortfolio : ITradePortfolio
    {
        public DateTime ReferenceDate { get ; set ; }
        public int NumberTradesOfPortFolio { get; set ; }      
        List<ITrade> ITradePortfolio.Trades { get ; set ; }
    }
}
