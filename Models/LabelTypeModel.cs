using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCLIB_DLL_IN_C_Sharp.Models
{
    public class LabelTypeModel
    {
        public int Id { get; set; }
        public String Dimension { get; set; }
        public String Unit { get; set; }

        public String Name {
        
        get 
            {
                return Dimension +' '+ Unit;
            } set { Name = Dimension + ' '+ Unit; }
        }

    }
}
