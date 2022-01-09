using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSCLIB_DLL_IN_C_Sharp.Models;

namespace TSCLIB_DLL_IN_C_Sharp.DataSource
{
    public  class LabelTypes
    {

        public static List<LabelTypeModel> labels()
        {
            var dataSource = new List<LabelTypeModel>();
            dataSource.Add(new LabelTypeModel() { Id = 1, Dimension = "29 x 13", Unit = "Milimetros" });
            dataSource.Add(new LabelTypeModel() { Id = 2, Dimension = "39 x 25", Unit = "Milimetros" });

            return dataSource;
        }

    }
}
