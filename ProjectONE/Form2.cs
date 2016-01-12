using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //button + pressed (vertex attributes)
        private void button3_Click(object sender, EventArgs e)
        {
            InputForm i = new InputForm("vertex", this);
            i.Visible = true;
            i.Activate();
        }

        /*
         * Permette di fare comunicare la finestra d'inserimento attributo con questa.
         * I parametri sono, in ordine, {vertex, edge}, il nome dell'attributo, il tipo {string, double, int} e i due estremi del range.
         */
        public void passParams(String type, String nomeattr, String cbsel, String range0, String range1)
        {
            if (type.Equals("vertex"))
                this.listbox_vertexattr.Items.Add(nomeattr + (cbsel.Equals("String") ? "":" - [" + range0 + ";" + range1 + "] (" + cbsel + ")"));
            else
                this.listbox_edgeattr.Items.Add(nomeattr + (cbsel.Equals("String") ? "" : " - [" + range0 + ";" + range1 + "] (" + cbsel + ")"));
        }

        //button - pressed (vertex attributes)
        private void button5_Click(object sender, EventArgs e)
        {
            this.listbox_vertexattr.Items.RemoveAt(this.listbox_vertexattr.SelectedIndex);
        }

        //button + pressed (edge attributes)
        private void button4_Click(object sender, EventArgs e)
        {
            InputForm i = new InputForm("edge", this);
            i.Visible = true;
            i.Activate();
        }

        //button - pressed (edge attributes)
        private void button6_Click(object sender, EventArgs e)
        {
            this.listbox_edgeattr.Items.RemoveAt(this.listbox_edgeattr.SelectedIndex);
        }

        //Create Tree
        private void button2_Click(object sender, EventArgs e)
        {
            int splitsize, depth;
            if(int.TryParse(textBox4.Text, out splitsize) && int.TryParse(textBox3.Text, out depth))
            {
                if(textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && listbox_edgeattr.Items.Count != 0 && listbox_vertexattr.Items.Count != 0)
                {
                    //TODO
                }
            }
        }

        //Choose button. Shows a FolderBrowserDialog
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            this.textBox2.Text = fbd.SelectedPath;
            
        }
    }
}
