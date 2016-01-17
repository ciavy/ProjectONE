using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectONE.GUI
{
    public partial class UploadTreeForm : Form
    {
        public UploadTreeForm()
        {
            InitializeComponent();
            this.Location = new Point((Screen.FromControl(this).Bounds.Width - this.Width) / 2, (Screen.FromControl(this).Bounds.Height - this.Height) / 2);
        }

        //Button to choose the directory of the tree to be upload to DB
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Multiselect = false;
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = fbd.FileName;
            }
        }
    }
}
