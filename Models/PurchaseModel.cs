using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCLIB_DLL_IN_C_Sharp
{
    public class PurchaseModel
    {

        public int Purchase_order_id { get; set; }
        public string Vendor{ get; set; }
        public string Ship_method { get; set; }
        public DateTime Order_date { get; set; }
    }
}
