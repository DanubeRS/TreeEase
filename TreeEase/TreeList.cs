using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutoCAD
{
    class TreeList
    {
        public List<Tree> trees { get; set; }

        public TreeList()
        {
            trees = new List<Tree>();
        }

        public void AddTree(Tree t){
            trees.Add(t);
        }
    }
}
