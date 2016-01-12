using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InputForm : Form
    {
        String type;
        Form2 form2;

        public InputForm(String t, Form2 f1ref)
        {
            InitializeComponent();
            comboBox1.Items.Add("String");
            comboBox1.Items.Add("Double");
            comboBox1.Items.Add("Integer");
            comboBox1.SelectedIndex = 0;
            type = t;
            this.form2 = f1ref;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedText != "String")
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
        }

        //inserire attributo
        private void button1_Click(object sender, EventArgs e)
        {
            if(!comboBox1.SelectedItem.ToString().Equals("String"))
            {
                double temp1, temp2;
                if (double.TryParse(textBox2.Text, out temp1) && double.TryParse(textBox3.Text, out temp2)) //both the values of the range are inserted?
                {
                    if (temp1 <= temp2) //range: n1 <= n2?
                    {
                        if (this.comboBox1.SelectedItem.ToString().Equals("Integer")) //attribute of type int
                            this.form2.passParams(this.type, textBox1.Text, comboBox1.SelectedItem.ToString(), ((int)temp1).ToString(), ((int)temp2).ToString());
                        else //attribute of type double
                            this.form2.passParams(this.type, textBox1.Text, comboBox1.SelectedItem.ToString(), temp1.ToString(), temp2.ToString());
                    }
                }
                return;
            }
            //attribute is of type string
            this.form2.passParams(this.type, textBox1.Text, comboBox1.SelectedItem.ToString(), "", "");
        }
    }
}
