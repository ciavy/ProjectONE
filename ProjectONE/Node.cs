using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class Node
    {
        Attribute[] Attributes { get; set; }
        public LinkedList<Edge> OutgoingEdges { get; set; }
        Edge IncomingEdge { get; set; }
        int Name { get; set; }

        public Node(int nodeName, Attribute[] attr)
        {
            this.Name = nodeName;
            this.Attributes = attr;
            this.OutgoingEdges = new LinkedList<Edge>();
        }

        public Node(int name)
        {
            this.Name = name;
            this.OutgoingEdges = new LinkedList<Edge>();
        }

        public Node(int nodeName, Attribute[] attr, LinkedList<Edge> edges)
        {
            this.OutgoingEdges = edges;
            this.Name = nodeName;
            this.Attributes = attr;
        }

        public void append(Edge edge)
        {
            this.OutgoingEdges.AddLast(edge);
        }

        public Tree toTree()
        {
            return null;
        }

        public override string ToString()
        {
            String s = Name.ToString() + ":";
            foreach (Attribute a in Attributes)
                s += "\n\t" + a.ToString();
            return s;
        }
    }
}
