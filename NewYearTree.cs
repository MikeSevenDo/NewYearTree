using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTree
{
    class NewYearTree
    {
        List<NewYearItem> TreeList;
        int Height { get; set; }
        NewYearTree(int height)
        {
            TreeList = new List<NewYearItem>();
            GetNewYearTree();
        }
        void GetNewYearTree()
        {

        }
    }
}
