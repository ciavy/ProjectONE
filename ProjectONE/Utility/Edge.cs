using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    /// <summary>
    /// Represents an edge of the tree, with its random-generable attributes.
    /// An edge connects two Vertexs.
    /// </summary>
    class Edge
    {
        public LinkedList<Attribute> Attributes; //instance attributes for this edge
        public Vertex Top { get; set; }
        public Vertex Bottom { get; set; }
        public String Name { get; set; }

        public Edge(int name, Vertex top, Vertex bottom)
        {
            this.Name = "edge" + name;
            this.Top = top;
            this.Bottom = bottom;
        }

        public Edge(int name, Vertex top, Vertex btm, LinkedList<Attribute> attr) : this(name, top, btm)
        {
            this.Attributes = attr;
        }

        public Edge(int name, Vertex top, Vertex btm, Attribute attr) : this(name, top, btm)
        {
            Attributes = new LinkedList<Attribute>();
            Attributes.AddLast(attr);
        }

        public override string ToString()
        {
            String s = "edge" + this.Name.ToString() + ":";

            if (Attributes == null)
                return s;

            foreach (Attribute a in Attributes)
                s += "\n\t" + a.ToString();
            return s;
        }

    }
}
