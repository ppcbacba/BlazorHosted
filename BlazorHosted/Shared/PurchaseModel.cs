using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorHosted.Shared
{
  public  class PurchaseModel
    {
        public string id { get; set; }
        public DateTime datecreated { get; set; }
        public List<string> products { get; set; }
        public string buyer { get; set; }
    }
}
