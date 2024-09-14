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

                if (isExpired(trade))
                    Console.WriteLine("EXPIRED");
                else if (isHighRisk(trade))
                    Console.WriteLine("HIGHRISK");
                else if (isMediumRisk(trade))
                    Console.WriteLine("MEDIUMRISK");
            }
        }

        private bool isExpired(ITrade trade)
        {
            return trade.NextPaymentDate.Date < DateTime.Now.AddDays(30);
        }

        private bool isHighRisk(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector.Equals("Private");
        }

        private bool isMediumRisk(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector.Equals("Public");

        }
    }
}
