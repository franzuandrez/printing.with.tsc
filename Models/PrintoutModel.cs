using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCLIB_DLL_IN_C_Sharp.Models
{
    public class PrintoutModel
    {

        public int Id { get; set; }
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public int Quantity_Printed { get; set; }
        public int Printed_By { get; set; }
        public bool Is_Printed { get; set; }
    }
}
