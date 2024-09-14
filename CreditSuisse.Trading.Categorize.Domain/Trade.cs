﻿using CreditSuisse.Trading.Categorize.Domain.Interfaces;

namespace CreditSuisse.Trading.Categorize.Domain
{
    public class Trade : ITrade
    {
        public double Value { get; set ; }
        public string ClientSector { get ; set ; }
        public DateTime NextPaymentDate { get ; set ; }
        public bool IsPoliticallyExposed { get; set ; }
    }
}
