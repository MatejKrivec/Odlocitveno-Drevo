using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektnaNaloga_Krivec
{
    [Serializable]
    public class TreeNodeData
    {
        public string Text { get; set; }
        public Vrednosti Tag { get; set; }
        public List<TreeNodeData> Children { get; set; }

        public TreeNodeData()
        {
            Children = new List<TreeNodeData>();
        }
    }
}
