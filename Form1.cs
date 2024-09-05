using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Properties.Settings.Default.Username && textBox2.Text == Properties.Settings.Default.Pass)
            {
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
