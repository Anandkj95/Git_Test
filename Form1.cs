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
            int i =0;
            int a = 0;
            int b = 0;
            int sum = 0;
            for(i=0;i<=4;i++)
            {
                sum = a + b;
                a = b;
                b= sum;
                textBox1.Text=(b.ToString());
            }
        }
    }
}