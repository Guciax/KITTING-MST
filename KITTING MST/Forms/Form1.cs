using KITTING_MST.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DataTable lotTable = MST.MES.SqlOperations.Kitting.GetKittingTableForLots(new string[] { textBoxLotNumber.Text });
                if (lotTable.Rows.Count > 0)
                {
                    //load LOT
                    labelLotNumber.Text = textBoxLotNumber.Text;
                    label12NC.Text = lotTable.Rows[0]["NC12_wyrobu"].ToString();
                    labelOrderedQty.Text = lotTable.Rows[0]["Ilosc_wyrobu_zlecona"].ToString();
                    labelStartDate.Text = lotTable.Rows[0]["Data_Poczatku_Zlecenia"].ToString();
                    labelLedsPerModel.Text = lotTable.Rows[0]["IloscDiodNaWyrob"].ToString();
                    
                    LedReels.AddLedReelsForLot(textBoxLotNumber.Text, dataGridViewLedReels);
                    textBoxLotNumber.Text = "";
                }
                else
                {
                    using (AddNewLot lotForm = new AddNewLot(textBoxLotNumber.Text))
                    {
                        if (lotForm.ShowDialog() == DialogResult.OK)
                        {
                            labelLotNumber.Text = textBoxLotNumber.Text;
                            label12NC.Text = lotForm.model;
                            labelOrderedQty.Text = lotForm.orderedQty;
                            labelStartDate.Text = DateTime.Now.ToString();
                            labelLedsPerModel.Text = lotForm.ledPerModel;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelLotNumber.Text.Length > 6)
            {
                using (AddLedReel ledForm = new AddLedReel())
                {
                    ledForm.ShowDialog();
                    string id = ledForm.id;
                    string nc12 = ledForm.nc12;

                    MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieString(nc12, id, labelLotNumber.Text);
                    LedReels.AddReelToGrid(nc12, id, dataGridViewLedReels);
                }
            }
        }
    }
}
