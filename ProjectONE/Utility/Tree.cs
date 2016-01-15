using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectONE
{
    /*
     * Represents a tree, with SplitSize child-nodes and Depth levels.
     * This tree is complete and each node and edge have some well defined attributes.
     * This tree can be either auto-generated or build manually from scratch.
     */
    class Tree
    {
        public Node root { get; set; }
        public String type { get; set; } //Name of the tree
        int SplitSize { get; set; } //how many childs a node has
        int Depth { get; set; } //levels of the tree
        LinkedList<Attribute> VertexAttributes { get; set; } //list of attributes that nodes have
        LinkedList<Attribute> EdgeAttributes {get ; set; } //list of attributes that nodes have

        /// <summary>
        /// Constructs a tree with the following parameters
        /// </summary>
        /// <param name="splitSize">splitsize of the tree</param>
        /// <param name="depth">depth of the tree</param>
        /// <param name="vertexAttributes">attributes of each vertex</param>
        /// <param name="edgeAttributes">attributes of each edge</param>
        public Tree(int splitSize, int depth, LinkedList<Attribute> vertexAttributes, LinkedList<Attribute> edgeAttributes)
        {
            this.SplitSize = splitSize;
            this.Depth = depth;
            this.VertexAttributes = vertexAttributes;
            this.EdgeAttributes = edgeAttributes;
        }

        /// <summary>
        /// Constructs a new tree, with a given splitsize and depth.
        /// Note: vertex and edge attributes are set to null, so you have to set them manually
        /// </summary>
        /// <param name="splitSize"></param>
        /// <param name="depth"></param>
        public Tree(int splitSize, int depth)
        {
            this.SplitSize = splitSize;
            this.Depth = depth;
            this.VertexAttributes = null;
            this.EdgeAttributes = null;
        }



        /// <summary>
        /// returns true if this tree is empty (ie no node nor edge is contained)
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return root == null;
        }

        /// <summary>
        /// returns the root node of this tree
        /// </summary>
        /// <returns></returns>
        public Node getRoot()
        {
            return root;
        }

        /// <summary>
        /// Deallocates this tree.
        /// </summary>
        public void clear()
        {
            root = null;
        }

        /// <summary>
        /// Applies preorder ordering to this tree
        /// </summary>
        /// <returns>tree as preorder string</returns>
        public String preorder()
        {
            if (this.root == null)
                return "";

            String res = "NODE " + this.root.ToString();

            if (this.root.OutgoingEdges == null)
                return res;

            foreach(Edge e in this.root.OutgoingEdges)
            {
                res += "\nEDGE " + e.ToString() + "\n";
                Tree subtree = new Tree(SplitSize, Depth - 1, VertexAttributes, EdgeAttributes);
                subtree.root = e.Bottom;
                res += subtree.preorder();
            }
            return res;
        }

        private void preorderXML_edges(XmlWriter writer)
        {
            if (this.root == null)
                return;

            if (this.root.OutgoingEdges == null || this.root.OutgoingEdges.Count == 0)
                return;

            
            foreach (Edge e in this.root.OutgoingEdges)
            {
                writer.WriteStartElement("Edge");
                writer.WriteElementString("Name", e.Name.ToString());
                writer.WriteElementString("Top", e.Top.Name.ToString());
                writer.WriteElementString("Bottom", e.Bottom.Name.ToString());
                writer.WriteStartElement("Attributes");
                foreach (Attribute a in e.Attributes)
                {
                    writer.WriteStartElement("Attribute");
                    writer.WriteElementString("Type", a.type.ToString());
                    writer.WriteElementString("Name", a.Name);
                    if (a.type == Attribute.AttributeType.STRING)
                        writer.WriteElementString("Value", a.value_string);
                    else
                    {
                        writer.WriteElementString("Value", a.type == Attribute.AttributeType.INT ? a.value_int.ToString() : a.value_double.ToString());
                        writer.WriteElementString("Lowerbound", a.lowerbound.ToString());
                        writer.WriteElementString("Upperbound", a.upperbound.ToString());
                    }
                    writer.WriteEndElement(); //Attribute
                }
                writer.WriteEndElement(); //Attributes
                writer.WriteEndElement(); //Edge
                Tree subtree = new Tree(SplitSize, Depth - 1, VertexAttributes, EdgeAttributes);
                subtree.root = e.Bottom;
                subtree.preorderXML_edges(writer);
            }
        }

        private void preorderXML_vertexes(XmlWriter writer)
        {
            if (this.root == null)
                return;

            if (this.root.OutgoingEdges == null)
                return;

            writer.WriteStartElement("Vertex");
            writer.WriteElementString("Name", this.root.Name.ToString());
            writer.WriteElementString("Level", this.root.Level.ToString());
            writer.WriteStartElement("Attributes");
            foreach(Attribute a in this.root.Attributes)
            {
                writer.WriteStartElement("Attribute");
                writer.WriteElementString("Type", a.type.ToString());
                writer.WriteElementString("Name", a.Name);
                if (a.type == Attribute.AttributeType.STRING)
                    writer.WriteElementString("Value", a.value_string);
                else
                {
                    writer.WriteElementString("Value", a.type == Attribute.AttributeType.INT ? a.value_int.ToString() : a.value_double.ToString());
                    writer.WriteElementString("Lowerbound", a.lowerbound.ToString());
                    writer.WriteElementString("Upperbound", a.upperbound.ToString());
                }
                writer.WriteEndElement(); //Attribute
            }
            writer.WriteEndElement(); //Attributes

            writer.WriteStartElement("OutgoinEdges");
            foreach (Edge e in this.root.OutgoingEdges)
            {
                writer.WriteStartElement("Edge");
                writer.WriteElementString("Name", e.Name.ToString());
                writer.WriteEndElement(); //Edge
            }
            writer.WriteEndElement(); //OutgoingEdges
            writer.WriteEndElement(); //Vertex

            foreach (Edge e in this.root.OutgoingEdges)
            {
                Tree subtree = new Tree(SplitSize, Depth - 1, VertexAttributes, EdgeAttributes);
                subtree.root = e.Bottom;
                subtree.preorderXML_vertexes(writer);
            }
        }

        /// <summary>
        /// Writes this tree to file, using preorder
        /// </summary>
        /// <returns>true on success</returns>
        public bool ToFile(String path)
        {
            //Write general information
            if (!System.IO.Directory.Exists(path))
                return false;

            if (this.type.EndsWith(".xml") == false)
                this.type += ".xml";

            if(path.EndsWith("/") == false && path.EndsWith("\\") == false)
            {
                System.Windows.Forms.MessageBox.Show("Please let your directory end with a slash");
            }

            String completepath = path + this.type;
            using (XmlTextWriter writer = new XmlTextWriter(completepath, Encoding.ASCII))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;

                writer.WriteStartDocument();
                writer.WriteStartElement("Tree");
                writer.WriteStartElement("GeneralInformation");
                writer.WriteElementString("Type", this.type);
                writer.WriteElementString("SplitSize", this.SplitSize.ToString());
                writer.WriteElementString("Depth", this.Depth.ToString());

                writer.WriteStartElement("VertexesAttributes");
                foreach (Attribute a in this.VertexAttributes)
                {
                    writer.WriteStartElement("VertexAttribute");
                    writer.WriteElementString("Type", a.type.ToString());
                    writer.WriteElementString("Name", a.Name);
                    if (a.type != Attribute.AttributeType.STRING)
                    {
                        writer.WriteElementString("Lowerbound", a.lowerbound.ToString());
                        writer.WriteElementString("Upperbound", a.upperbound.ToString());
                    }
                    writer.WriteEndElement(); //VertexAttribute
                }
                writer.WriteEndElement(); //VertexesAttributes

                writer.WriteStartElement("EdgesAttributes");
                foreach(Attribute a in this.EdgeAttributes)
                {
                    writer.WriteStartElement("EdgeAttribute");
                    writer.WriteElementString("Type", a.type.ToString());
                    writer.WriteElementString("Name", a.Name);
                    if(a.type != Attribute.AttributeType.STRING)
                    {
                        writer.WriteElementString("Lowerbound", a.lowerbound.ToString());
                        writer.WriteElementString("Upperbound", a.upperbound.ToString());
                    }
                    writer.WriteEndElement(); //EdgeAttribute
                }
                writer.WriteEndElement(); //EdgesAttributes

                writer.WriteEndElement(); //GeneralInformation

                writer.WriteStartElement("Vertexes");
                this.preorderXML_vertexes(writer);
                writer.WriteEndElement(); //Vertex
                writer.WriteStartElement("Edges");
                this.preorderXML_edges(writer);
                writer.WriteEndElement(); //Edges

                writer.WriteEndElement(); //Tree
                writer.WriteEndDocument();
                writer.Close();
            }

            return true;
        }

        /// <summary>
        /// writes this tree to database, sending a request to the Engine.
        /// </summary>
        /// <returns>true on success</returns>
        public bool ToDatabase()
        {
            return false;
        }

        public override String ToString()
        {
            return this.preorder();
        }

        /// <summary>
        /// Generates random attributes, either for a vertex or for an edge.
        /// </summary>
        /// <param name="forVertex">true if attribute list is for a node</param>
        /// <param name="vertattrs">list of attributes of vertexes</param>
        /// <param name="edgeattrs">list of attributes of edges</param>
        /// <returns>a list of random attributes for either a vertex or for an edge</returns>
        private static LinkedList<Attribute> GetRandomAttributes(bool forVertex, LinkedList<Attribute> vertattrs, LinkedList<Attribute> edgeattrs)
        {
            if (forVertex) //if attributes list not set => do nothing
            {
                if (vertattrs == null)
                    return null;
            }
            else
            {
                if (edgeattrs == null)
                    return null;
            }

            LinkedList<Attribute> attr = new LinkedList<Attribute>();
            foreach (Attribute a in forVertex ? vertattrs : edgeattrs)
            {
                Attribute copy = a.Clone(); //well yes, it's needed indeed
                attr.AddLast(copy.generate());
            }
            return attr;
        }

        /// <summary>
        /// Counts nodes in this tree. For test
        /// </summary>
        /// <returns></returns>
        public int countNodes()
        {
            int n = 1;
            if (root.OutgoingEdges == null)
                return n;

            foreach(Edge e in root.OutgoingEdges)
            {
                Tree subtree = new Tree(SplitSize, Depth - 1, VertexAttributes, EdgeAttributes);
                subtree.root = e.Bottom;
                n += subtree.countNodes();
            }
            return n;
        }

        /// <summary>
        /// Generates a random tree with a given splitsize, depth and list of attributes for either vertexes and for edges.
        /// </summary>
        /// <param name="EdgeAttributes">List of attributes of each edge in the future tree</param>
        /// <param name="VertexAttributes">List of attributes of each vertex in the future tree</param>
        /// <returns>a random tree</returns>
        public static Tree getRandomTree( int Depth, int SplitSize, LinkedList<Attribute> VertexAttributes, LinkedList<Attribute> EdgeAttributes)
        { //generate per level: each node gets its childs
            //Console.WriteLine("depth: " + Depth + "; splitsize: " + SplitSize);
            Tree tree = new Tree(SplitSize, Depth, VertexAttributes, EdgeAttributes);
            Node root = new Node(1, GetRandomAttributes(true, VertexAttributes, EdgeAttributes).ToArray());
            tree.root = root;
            Queue<Node> stack = new Queue<Node>();
            stack.Enqueue(tree.root);
            Node curNode;
            int n = 2;
            for (int l = 1; l < Depth || stack.Count != 0; l++)
            {
                if (stack.Count != 0 && l >= Depth)
                    l--;
                
                curNode = stack.Dequeue();
                //Console.WriteLine("curNode:" + curNode);
                for (int s = 0; s < SplitSize; s++)
                {
                    Node childVertex = new Node((int) new MyRandom().Next(0, double.MaxValue) +  n++, GetRandomAttributes(true, VertexAttributes, EdgeAttributes).ToArray(), new LinkedList<Edge>(), l);
                    if (l != Depth - 1)
                    {
                        stack.Enqueue(childVertex);
                        //Console.WriteLine("childVx: " + childVertex.ToString());
                    }
                    curNode.append(new Edge((int) new MyRandom().Next(0, double.MaxValue) + n, curNode, childVertex, GetRandomAttributes(false, VertexAttributes, EdgeAttributes)));
                }
            }
            return tree;
        }
    }

}
