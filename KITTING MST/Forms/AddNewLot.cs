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
    public partial class AddNewLot : Form
    {
        private readonly string lotNo;
        public string model = "";
        public string orderedQty = "";
        public string ledPerModel = "";
        public int binQty = 0;

        public AddNewLot(string lotNo)
        {
            InitializeComponent();
            this.lotNo = lotNo;
        }

        private void textBox12NC_Leave(object sender, EventArgs e)
        {
            string nc12 = textBox12NC.Text.Trim().Replace(" ", "");
            if (nc12.Length > 0) 
            {
                DataTable modelTable = MST.MES.SqlOperations.Kitting.GetKittingTableForModel(nc12);
                if (modelTable.Rows.Count>0)
                {
                    textBoxLedQty.Text = modelTable.Rows[0]["IloscDiodNaWyrob"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model = textBox12NC.Text;
            orderedQty = textBoxOrderedQty.Text;
            ledPerModel = textBoxLedQty.Text;
            binQty = (int)numericUpDown1.Value;
        }

        private void textBox12NC_KeyPress(object sender, KeyPressEventArgs e)
        {
            int check = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out check);
        }

        private void AddNewLot_Load(object sender, EventArgs e)
        {
            labelLotNo.Text += lotNo;
        }

        private void textBoxOrderedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            int check = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out check);
        }

        private void textBoxLedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            int check = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out check);
        }

        
    }
}
