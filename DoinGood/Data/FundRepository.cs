﻿using DoinGood.Contracts;
using DoinGood.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class FundRepository : RepositoryBase<Fund>, IFundRepository
    {
        public FundRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Fund GetFund(int id) => FindByCondition(e => e.FundId == id).FirstOrDefault();
        public SelectList FundList()
        {
            var fundList = new SelectList(FindAll(), "FundId", "FundName");
            return fundList;
        }
        public void InspiredFund()
        {
            var inspiredFund = FindByCondition(e => e.FundId == 1).FirstOrDefault();
            inspiredFund.CurrentFunds++;
            Update(inspiredFund);
        }
    }
}
