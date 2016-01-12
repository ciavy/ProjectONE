using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class Edge
    {
        LinkedList<Attribute> attributes;
        Node Top { get; set; }
        public Node Bottom { get; set; }

        public Edge(Node top, Node bottom)
        {
            this.Top = top;
            this.Bottom = bottom;
        }

        public Edge(Node top, Node btm, LinkedList<Attribute> attr)
        {

        }
        
    }
}
