﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class InspiredFund
    {
        [Key]
        public int InspiredFundId { get; set; }

        public int CurrentFunds { get; set; }
    }
}
