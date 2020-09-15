using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHosted.Server.Controllers
{
    public class PurchaseController : ControllerBase
    {
        [Route("api/getpurchaselist")]
        public Task<List<PurchaseModel>> GetAllPurchase()
        {
            return Task.FromResult(FakeDatabase.purchases);

        }

        [Route("api/createpurchase")]
        public Task<bool> CreatePurchase([FromBody]PurchaseModel purchase)
        {
            try
            {
                FakeDatabase.purchases.Add(purchase);
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);

            }
        }
    }
}
