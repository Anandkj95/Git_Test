using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Git_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Anand..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Branch B button is Clicked..");
        }
    }
}
