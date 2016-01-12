using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class Tree
    {
        Node root { get; set; }
        int SplitSize { get; set; }
        int Depth { get; set; }
        LinkedList<Attribute> VertexAttributes, EdgeAttributes;

        public Tree(int splitSize, int depth, LinkedList<Attribute> vertexAttributes, LinkedList<Attribute> edgeAttributes)
        {
            this.SplitSize = splitSize;
            this.Depth = depth;
            this.VertexAttributes = vertexAttributes;
            this.EdgeAttributes = edgeAttributes;
        }

        public Tree(int splitSize, int depth)
        {
            this.SplitSize = splitSize;
            this.Depth = depth;
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public Node getRoot()
        {
            return root;
        }

        public void clear()
        {
            root = null;
        }

        private LinkedList<Attribute> GetRandomAttributes(bool forVertex)
        {
            LinkedList<Attribute> attr = new LinkedList<Attribute>();
            foreach(Attribute a in forVertex ? this.VertexAttributes : this.EdgeAttributes)
            {
                Attribute copy = a.Clone(); //ebbene sì, serve davvero XD
                attr.AddLast(copy.generate());
            }
            return attr;
        }

        public Tree getRandomTree()
        {
            Tree tree = new Tree(SplitSize, Depth, VertexAttributes, EdgeAttributes);
            Node root = new Node(0, this.GetRandomAttributes(true).ToArray());
            tree.root = root;
            Queue<Node> stack = new Queue<Node>();
            stack.Enqueue(tree.root);
            Node curNode;
            int n = 1;
            for (int l = 0; l < Depth; l++)
            {
                curNode = stack.Dequeue();
                for (int s = 0; s < SplitSize; s++)
                {
                    Node childVertex = new Node(n++, this.GetRandomAttributes(true).ToArray());
                    if(l != Depth - 1)
                        stack.Enqueue(childVertex);
                    curNode.append(new Edge(curNode, childVertex));
                }
            }
            return tree;
        }

        private String levelorder()
        {
            String s = "";
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this.root);
            do
            {
                Node curNode = queue.Dequeue();
                s += curNode.ToString() + "\n";
                foreach(Edge e in curNode.OutgoingEdges)
                    queue.Enqueue(e.Bottom);
            } while (queue.Count() != 0);
            return s;
        }

        public bool ToFile()
        {
            return false;
        }

        public bool ToDatabase()
        {
            return false;
        }

        public override String ToString()
        {
            return this.levelorder();
        }
    }

}
