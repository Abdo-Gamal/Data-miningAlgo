using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ItemSet : Dictionary<List<string>, int>
    {
        public string Label { get; set; }//item
        public int Support { get; set; }// frquance
    }
}
