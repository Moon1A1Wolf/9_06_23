using System.Windows.Forms;

namespace _9_06_23
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextBox;
            form2.UpdateForm(ref temp);
        }

        public void UpdateForm(ref TextBox temp)
        {
            textBox1.Text = temp.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
