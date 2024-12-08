using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_cw5
{
    internal class Element
    {
        public NodeG wezel;
        public int dystans;
        public NodeG poprzednik;
       
        public Element(NodeG wezel, int dystans, NodeG poprzednik)
        {
            this.wezel = wezel;
            this.dystans = int.MaxValue;
            this.poprzednik = null;
        }
    }
}
