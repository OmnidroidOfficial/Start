using Blazored.LocalStorage;
using Omnidroid_Start.Shared;
using System.Runtime.InteropServices;

namespace Omnidroid_Start.Client
{
    public class Three
    {
        static public void SortReviewOne()
        {
            if (PreSort.ReviewOne == true)
            {
                Universal.IfModuleHost = true;
            }
            if (PreSort.ReviewOne == false)
            {
                Universal.IfModuleHost = false;
            }
        }
    }
}
