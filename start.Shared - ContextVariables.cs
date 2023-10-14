using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid_Start.Shared
{
    public class ContextVariables
    {
        static public string? VarAini { get; set; }
        static public void ContextA()
        {
            VarAini = PreSort.VarA;
            SortClass.SortOne();
        }
    }
}
