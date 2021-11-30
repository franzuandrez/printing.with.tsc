using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCLIB_DLL_IN_C_Sharp.Models
{
    public class PrintoutModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public bool Is_Printed { get; set; }
    }
}
