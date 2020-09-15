using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;

namespace BlazorHosted.Server
{
    public class FakeDatabase
    {
        public static List<BuyerModel> buyers = new List<BuyerModel>();
        public static List<ProductModel> products = new List<ProductModel>();
        public static List<PurchaseModel> purchases=new List<PurchaseModel>();
    }
}
