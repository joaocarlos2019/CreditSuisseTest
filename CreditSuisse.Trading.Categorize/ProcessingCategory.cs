using CreditSuisse.Trading.Categorize.Domain;
using CreditSuisse.Trading.Categorize.Domain.Enums;
using CreditSuisse.Trading.Categorize.Domain.Interfaces;

namespace CreditSuisse.Trading.Categorize.Main
{
    public class ProcessingCategory : IProcessingCategory
    {
       
        public void DoCategorize(ITradePortfolio tradeSended)
        {

            foreach(var trade in tradeSended.Trades)
            {

                if (trade.isExpired())
                    Console.WriteLine("EXPIRED");
                else if (trade.isHighRisk())
                    Console.WriteLine("HIGHRISK");
                else if (trade.isMediumRisk())
                    Console.WriteLine("MEDIUMRISK");
            }
        }

        
    }
}
