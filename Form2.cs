using System;
using System.Windows.Forms;

namespace KeyAuth_Admin_Panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
