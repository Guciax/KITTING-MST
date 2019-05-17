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
        private readonly string modelId;
        private readonly int pcbPerMb;
        public int newQty = 0;

        public ChangeOrderQty(int oldQty, string modelId, int pcbPerMb)
        {
            InitializeComponent();
            this.oldQty = oldQty;
            this.modelId = modelId;
            this.pcbPerMb = pcbPerMb;
        }

        private void ChangeOrderQty_Load(object sender, EventArgs e)
        {
            textBox1.Text = oldQty.ToString();
            lModelInfo.Text += Environment.NewLine + modelId + Environment.NewLine + $"Ilość PCB/MB: {pcbPerMb}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0 & int.TryParse(textBox1.Text, out newQty)) 
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                if (!int.TryParse(e.KeyChar.ToString(), out int i)) e.Handled = true;
            }
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double qty = 0;
            if(double.TryParse(textBox1.Text, out qty))
            {
                var mbCount = Math.Round(qty / pcbPerMb, 2);
                lMbInfo.Text = $"Potrzebna ilość MB: {mbCount}" + Environment.NewLine;
                if (mbCount % 1 != 0)
                {
                    lMbInfo.Text += $"Aby zaokrąglić do pełnych MB wpisz: {Math.Ceiling(mbCount) * pcbPerMb}";
                }
            }
            else
            {
                lMbInfo.Text = "Wpisz ilość";
            }
            
        }
    }
}
