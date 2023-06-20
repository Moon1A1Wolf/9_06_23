using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _9_06_23;

namespace _9_06_23
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextBox;
            form1.UpdateForm(ref temp);
        }
        public void UpdateForm(ref TextBox temp)
        {
            textBox1.Text = temp.Text;
        }
    }
}
