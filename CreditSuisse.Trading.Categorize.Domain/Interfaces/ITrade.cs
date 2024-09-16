﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Trading.Categorize.Domain.Interfaces
{
    public interface ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public bool IsPoliticallyExposed { get; set; }

        public bool isExpired();

        public bool isHighRisk();

        public bool isMediumRisk();
       




    }
}
