using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid_Start.Shared
{
    public class SortClass
    {
        public static void SortOne()
        {
            if (ContextVariables.VarAini == "Miss")
            {
                PreSort.ReviewOne = true;
            }
            if (ContextVariables.VarAini == "Mrs")
            {
                PreSort.ReviewOne = true;
            }
            if (ContextVariables.VarAini == "Mister")
            {
                PreSort.ReviewOne = false;
            }
            if (ContextVariables.VarAini == "(To be further specified)")
            {
                PreSort.ReviewOne = false;
            }

        }
    }
}
