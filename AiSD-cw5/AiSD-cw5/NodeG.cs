using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_cw5
{
    internal class NodeG
    {
        public NodeG start;
        public NodeG end;
        public NodeG(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
