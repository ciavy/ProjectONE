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
            LinkedList<Attribute> edgeattrlist = new LinkedList<Attribute>();
            edgeattrlist.AddLast(new Attribute("e1", Attribute.AttributeType.DOUBLE, 1.0, 5.9));
            edgeattrlist.AddLast(new Attribute("e2", Attribute.AttributeType.STRING, 0.0, 0.0));
            LinkedList<Attribute> vertexattrlist = new LinkedList<Attribute>();
            vertexattrlist.AddLast(new Attribute("v1", Attribute.AttributeType.INT, 1, 10));
            vertexattrlist.AddLast(new Attribute("v2", Attribute.AttributeType.DOUBLE, 6.2, 10.5));
            vertexattrlist.AddLast(new Attribute("v3", Attribute.AttributeType.STRING, 0.0, 0.0));
            Tree tree = new Tree(2, 2, vertexattrlist, edgeattrlist);
            tree = tree.getRandomTree();
            richTextBox1.Text = tree.ToString();
            tree.ToFile();
            tree.ToDatabase();
        }
    }
}
