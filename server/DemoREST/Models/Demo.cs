using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoREST.Models
{
    public class Demo
    {
        public Dictionary<string, Dictionary<string, string>> Columns
        {
            get;set;
        }

        public List<RowData> Data
        {
            get;set;
        }
    }
}
