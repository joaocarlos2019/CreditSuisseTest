using CreditSuisse.Trading.Categorize.Domain;
using CreditSuisse.Trading.Categorize.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Trading.Categorize.Main
{
    public class ProcessingCategoryWithPep : IProcessingCategory
    {
        public void DoCategorize(ITradePortfolio tradeSended)
        {
            foreach (var trade in tradeSended.Trades)
            {
                
                if (trade.isExpired())
                    Console.WriteLine("EXPIRED");
                else if(trade.IsPoliticallyExposed)
                        Console.WriteLine("PEP");
                else if (trade.isHighRisk())
                    Console.WriteLine("HIGHRISK");
                else if (trade.isMediumRisk())
                    Console.WriteLine("MEDIUMRISK");

               
            }
        }
        
    }
}
