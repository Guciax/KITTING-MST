using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST.Forms
{
    public partial class AddModelNameManually : Form
    {
        public string modelName = "";
        public AddModelNameManually()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                modelName = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
