﻿using Common.Domain;

namespace NewApp.Domain
{
    public class RoundMetric
    {
        public int RoundNumber { get; set; }
        public decimal TotalLoss { get; set; }
        public Loss MaxLoss { get; set; }
    }
}