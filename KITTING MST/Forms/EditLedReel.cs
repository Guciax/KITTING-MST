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
    public partial class EditLedReel : Form
    {
        private readonly string currentOrder;
        private readonly string currentBin;
        private readonly int binQty;
        public string newOrder = "";
        public string newBin = "";

        public EditLedReel(string currentOrder, string currentBin, int binQty)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
            this.currentBin = currentBin;
            this.binQty = binQty;
        }

        private void EditLedReel_Load(object sender, EventArgs e)
        {
            labelCurrentData.Text += Environment.NewLine + $"Zlecenie: {currentOrder}" + Environment.NewLine + $"BIN: {currentBin}";
            textBoxNewOrder.Text = currentOrder;

            char bin = 'A';
            for (int i = 0; i < binQty; i++)
            {
                comboBox1.Items.Add(bin.ToString());
                bin++;
            }
            comboBox1.Text = currentBin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNewOrder.Text.Trim()!="" & comboBox1.Text.Trim() != "")
            {
                newOrder = textBoxNewOrder.Text;
                newBin = comboBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
