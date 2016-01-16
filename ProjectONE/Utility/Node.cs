using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    /// <summary>
    /// Represents a Vertex of the tree, with its random-generable attributes and edges.
    /// A Vertex has a name, [splitSize] outgoing edges and only one incoming edge.
    /// </summary>
    class Vertex
    {
        public Attribute[] Attributes { get; set; } //instance attributes, already generated
        public LinkedList<Edge> OutgoingEdges { get; set; } //vertici uscenti dal nodo
        public Edge IncomingEdge { get; set; }
        public String Name { get; set; } //name of the Vertex
        public int Level { get; set; } //level of this Vertex

        public Vertex(int VertexName, Attribute[] attr) : this(VertexName)
        {
            this.Attributes = attr;
        }

        public Vertex(int name)
        {
            this.Name = "vertex" + name;
            this.OutgoingEdges = new LinkedList<Edge>();
        }

        public Vertex(int VertexName, Attribute[] attr, LinkedList<Edge> edges, int level) : this(VertexName, attr)
        {
            this.OutgoingEdges = edges;
            this.Level = level;
        }

        public Vertex(int VertexName, Attribute attr) : this(VertexName)
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
