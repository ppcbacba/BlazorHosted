using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorHosted.Shared
{
  public  class ProductModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double value { get; set; }
        public bool available { get; set; }
    }
}
