using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    /// <summary>
    /// Represents a node of the tree, with its random-generable attributes and edges.
    /// A node has a name, [splitSize] outgoing edges and only one incoming edge.
    /// </summary>
    class Node
    {
        public Attribute[] Attributes { get; set; } //instance attributes, already generated
        public LinkedList<Edge> OutgoingEdges { get; set; } //vertici uscenti dal nodo
        public Edge IncomingEdge { get; set; }
        public String Name { get; set; } //name of the node
        public int Level { get; set; } //level of this node

        public Node(int nodeName, Attribute[] attr) : this(nodeName)
        {
            this.Attributes = attr;
        }

        public Node(int name)
        {
            this.Name = "vertex" + name;
            this.OutgoingEdges = new LinkedList<Edge>();
        }

        public Node(int nodeName, Attribute[] attr, LinkedList<Edge> edges, int level) : this(nodeName, attr)
        {
            this.OutgoingEdges = edges;
            this.Level = level;
        }

        public Node(int nodeName, Attribute attr) : this(nodeName)
        {
            this.Attributes = new Attribute[1];
            this.Attributes[0] = attr;
        }

        public void append(Edge edge)
        {
            this.OutgoingEdges.AddLast(edge);
        }

        public override string ToString()
        {
            String s = "vertex" + Name.ToString() + ":";
            foreach (Attribute a in Attributes)
                s += "\n\t" + a.ToString();
            return s;
        }
    }
}
