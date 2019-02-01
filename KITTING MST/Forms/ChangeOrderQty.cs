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
    public partial class ChangeOrderQty : Form
    {
        private readonly int oldQty;
        public int newQty = 0;

        public ChangeOrderQty(int oldQty)
        {
            InitializeComponent();
            this.oldQty = oldQty;
        }

        private void ChangeOrderQty_Load(object sender, EventArgs e)
        {
            textBox1.Text = oldQty.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length>0 & int.TryParse(textBox1.Text, out newQty))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
