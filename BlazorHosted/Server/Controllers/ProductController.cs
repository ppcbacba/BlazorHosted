using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHosted.Server.Controllers
{
    public class ProductController : ControllerBase
    {
        [Route("api/getproductlist")]
        public Task<List<string>> GetAllProducts()
        {
            return Task.FromResult(FakeDatabase.products.Select(x => x.id).ToList());
        }

        [Route("api/getproductdetails")]
        public Task<ProductModel> GetDetailsForSingleProduct(string id)
        {
            return Task.FromResult(FakeDatabase.products.Find(x => x.id == id));

        }

        [Route("api/createproduct")]
        public Task<bool> CreateProduct([FromBody] ProductModel product)
        {
            try
            {
                FakeDatabase.products.Add(product);
                return Task.FromResult(true);
            }
            catch 
            {
                return Task.FromResult(false);
            }
        }

        [Route("api/removeproduct")]
        public Task<bool> RemoveProduct(string id)
        {
            try
            {
                var result=FakeDatabase.products.FirstOrDefault(x => x.id == id);
                if (result != null)
                {
                    result.available = false;
                }
                return Task.FromResult(true);

            }
            catch
            {
                return Task.FromResult(false);
            }
        }
    }
}
