using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHosted.Server.Controllers
{
   
    [ApiController]
    public class BuyerController : ControllerBase
    {
        [Route("api/getbuyerlist")]
        public Task<List<string>> GetAllBuyers()
        {
            var templist = FakeDatabase.buyers.Select(item => item.id).ToList();
            return Task.FromResult(templist);

        }

        [Route("api/getbuyerdetails")]
        public Task<BuyerModel> GetDetailsForSingleBuyer(string id)
        {
            return Task.FromResult(FakeDatabase.buyers.Find(x => x.id == id));

        }

        [Route("api/createbuyer")]
        public Task<bool> CreateBuyer([FromBody] BuyerModel buyer)
        {
            try
            {
                FakeDatabase.buyers.Add(buyer);
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);

            }
        }
    }
}
