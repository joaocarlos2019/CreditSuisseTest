using CreditSuisse.Trading.Categorize.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Trading.Categorize.Main
{
    public class MainProcessing
    {
        private IProcessingCategory _processingCategory;

        public MainProcessing(IProcessingCategory processingCategory)
        {
            _processingCategory = processingCategory;
        }

        public void DoCategorize(ITradePortfolio tradePortFolio)
        {
            _processingCategory.DoCategorize(tradePortFolio);
        }
        
         
    }
}
