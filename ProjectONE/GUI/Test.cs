using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectONE
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //Test 1
            LinkedList<Attribute> edgeattrlist = new LinkedList<Attribute>();
            edgeattrlist.AddLast(new Attribute("e1", Attribute.AttributeType.DOUBLE, 1.0, 5.9));
            edgeattrlist.AddLast(new Attribute("e2", Attribute.AttributeType.STRING, 0.0, 0.0));
            LinkedList<Attribute> vertexattrlist = new LinkedList<Attribute>();
            vertexattrlist.AddLast(new Attribute("v1", Attribute.AttributeType.INT, 1, 10));
            vertexattrlist.AddLast(new Attribute("v2", Attribute.AttributeType.DOUBLE, 6.2, 10.5));
            vertexattrlist.AddLast(new Attribute("v3", Attribute.AttributeType.STRING, 0.0, 0.0));
            Tree tree = Tree.getRandomTree(3,5,vertexattrlist,edgeattrlist);
            Console.WriteLine("Vertexs in tree: " + tree.countVertexs()); // 31 */
            
            /*
            //Test 2 (albero from scratch)
            LinkedList<Attribute> vertexattrlist = new LinkedList<Attribute>();
            vertexattrlist.AddLast(new Attribute("vattr", Attribute.AttributeType.INT, "1"));

            LinkedList<Attribute> edgeattrlist = new LinkedList<Attribute>();
            Attribute e1 = new Attribute("eattr", Attribute.AttributeType.INT, "1");
            edgeattrlist.AddLast(e1);

            Vertex n1 = new Vertex(1, new Attribute("vattr", Attribute.AttributeType.INT, "1"));
            Vertex n2 = new Vertex(2, new Attribute("vattr", Attribute.AttributeType.INT, "2"));
            Vertex n3 = new Vertex(3, new Attribute("vattr", Attribute.AttributeType.INT, "3"));
            Vertex n4 = new Vertex(4, new Attribute("vattr", Attribute.AttributeType.INT, "4"));
            Vertex n5 = new Vertex(5, new Attribute("vattr", Attribute.AttributeType.INT, "5"));
            Vertex n6 = new Vertex(6, new Attribute("vattr", Attribute.AttributeType.INT, "6"));
            Vertex n7 = new Vertex(7, new Attribute("vattr", Attribute.AttributeType.INT, "7"));

            Edge ed1 = new Edge(1, n1, n2, new Attribute("eattr", Attribute.AttributeType.INT, "1"));
            Edge ed2 = new Edge(2, n1, n3, new Attribute("eattr", Attribute.AttributeType.INT, "2"));
            Edge ed3 = new Edge(3, n2, n4, new Attribute("eattr", Attribute.AttributeType.INT, "3"));
            Edge ed4 = new Edge(4, n2, n5, new Attribute("eattr", Attribute.AttributeType.INT, "4"));
            Edge ed5 = new Edge(5, n3, n6, new Attribute("eattr", Attribute.AttributeType.INT, "5"));
            Edge ed6 = new Edge(6, n3, n7, new Attribute("eattr", Attribute.AttributeType.INT, "6"));

            LinkedList<Edge> o1 = new LinkedList<Edge>();
            o1.AddLast(ed1);
            o1.AddLast(ed2);
            LinkedList<Edge> o2 = new LinkedList<Edge>();
            o2.AddLast(ed3);
            o2.AddLast(ed4);
            LinkedList<Edge> o3 = new LinkedList<Edge>();
            o3.AddLast(ed5);
            o3.AddLast(ed6);

            n1.OutgoingEdges = o1;
            n2.OutgoingEdges = o2;
            n3.OutgoingEdges = o3;
            n4.OutgoingEdges = null;
            n5.OutgoingEdges = null;
            n6.OutgoingEdges = null;
            n7.OutgoingEdges = null;

            Tree tree = new Tree(2, 3, edgeattrlist, vertexattrlist);
            tree.root = n1;
            */

            /*richTextBox1.Text = tree.ToString();
            tree.ToFile();
            tree.ToDatabase();*/
        }
    }
}
