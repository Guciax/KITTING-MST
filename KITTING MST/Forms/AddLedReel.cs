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
        private readonly int binQty;
        public string binId = "";

        public AddLedReel(int binQty)
        {
            InitializeComponent();
            this.binQty = binQty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //this.ActiveControl = textBox1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendReel();
            }
        }

        private void SendReel()
        {
            string[] split = textBox1.Text.Split('\t');
            if (split.Length > 4)
            {
                id = split[5];
                nc12 = split[0];
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void AddLedReel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            char bin = 'A';
            for (int i = 0; i < binQty; i++) 
            {
                comboBox1.Items.Add(bin.ToString());
                bin++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            binId = comboBox1.Text;
            textBox1.Visible = true;
            labelInfo.Text = "Zeskanuj kod QR rolki LED";
            this.ActiveControl = textBox1;
        }
    }
}
