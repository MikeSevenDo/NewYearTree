using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTree
{
    class TreeNeedle : NewYearItem
    {
        TreeNeedle(int x, int y, char c) : base(x, y)
        {
            View = c;
        }
    }
}
