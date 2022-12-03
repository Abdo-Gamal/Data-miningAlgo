using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AssociationRule
    {
        public string Label { get; set; }// item 
        public double Confidance { get; set; } //like A==>B
        public double Support { get; set; }      // like A==>D but not same rule of confedanc
    }
}
