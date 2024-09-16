// See https://aka.ms/new-console-template for more information
using CreditSuisse.Trading.Categorize.Domain;
using CreditSuisse.Trading.Categorize.Domain.Interfaces;
using CreditSuisse.Trading.Categorize.Main;

//Criando Trade De Entrada

ITradePortfolio tradePortFolio = new TradePortfolio();
tradePortFolio.ReferenceDate = new DateTime(2020, 11, 12);
tradePortFolio.NumberTradesOfPortFolio = 4;
tradePortFolio.Trades = new List<ITrade>();
tradePortFolio.Trades.Add(new Trade { Value = 2000000, ClientSector = "Private",NextPaymentDate= new DateTime(2025,12,29) });
tradePortFolio.Trades.Add(new Trade { Value = 400000, ClientSector = "Public", NextPaymentDate = new DateTime(2020,07,01) });
tradePortFolio.Trades.Add(new Trade { Value = 5000000, ClientSector = "Public", NextPaymentDate = new DateTime(2024,01,02) });
tradePortFolio.Trades.Add(new Trade { Value = 3000000, ClientSector = "Public", NextPaymentDate = new DateTime(2023, 10, 26) });
tradePortFolio.Trades.Add(new Trade { Value = 2000000, ClientSector = "Private", NextPaymentDate = new DateTime(2025, 12, 29),IsPoliticallyExposed=true });

//Executando Processamento Questao 1

IProcessingCategory processingCategory = new ProcessingCategory();

var processPrincipal = new MainProcessing(processingCategory);

processPrincipal.DoCategorize(tradePortFolio);

//Executando Processamento Questao 2

IProcessingCategory processingCategoryWithPep = new ProcessingCategoryWithPep();

var processPrincipalWithPep = new MainProcessing(processingCategoryWithPep);

processPrincipalWithPep.DoCategorize(tradePortFolio);
