using CreditSuisse.Trading.Categorize.Domain.Enums;
using CreditSuisse.Trading.Categorize.Domain;

namespace CreditSuisse.Trading.Categorize.Main
{
    public interface IProcessingCategory
    {
        public void DoCategorize(ITradePortfolio tradeSended);
    }
}
