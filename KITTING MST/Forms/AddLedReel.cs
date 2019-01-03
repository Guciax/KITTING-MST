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
    public partial class AddLedReel : Form
    {
        public string nc12 = "";
        public string id = "";

        public AddLedReel()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string[] split = textBox1.Text.Split('\t');
                if (split.Length>4)
                {
                    id = split[5];
                    nc12 = split[0];
                    this.Close();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void AddLedReel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }
    }
}
