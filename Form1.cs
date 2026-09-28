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
            TextBox txtName = new TextBox();

            txtName.Name = "txtName";
            txtName.Location = new Point(50, 50);
            txtName.Size = new Size(200, 30);

            this.Controls.Add(txtName);
        }
    }
}
