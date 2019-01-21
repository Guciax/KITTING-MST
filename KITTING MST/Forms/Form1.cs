using KITTING_MST.DataStructure;
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
        CurrentOrder currentOrder = new CurrentOrder("", DateTime.Now, 0, 0, "", "", 0, 0, 0);
        Dictionary<string, string> currentBins = new Dictionary<string, string>();
        bool release = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if DEBUG
            //button2.Visible = true;
            release = false;
            #endif
            dataGridViewLedReels.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
        }

        private void UpdateLabels()
        {
            labelLotNumber.Text = currentOrder.LotNumber;
            label12NC.Text = currentOrder.ModelNc10;
            labelOrderedQty.Text = currentOrder.OrderedQty.ToString();
            labelStartDate.Text = currentOrder.StartDate.ToShortDateString();
            labelLedsPerModel.Text = currentOrder.LedsPerModel.ToString();
            labelBinQty.Text = currentOrder.BinQty.ToString();
            labelModelName.Text = currentOrder.ModelName;

            labelRequiredLeds.Text = (currentOrder.OrderedQty * currentOrder.LedsPerModel).ToString();
        }

        private void textBoxLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxLotNumber.Text.Length > 5)
            {
                if (e.KeyCode == Keys.Return)
                {
                    currentOrder = new CurrentOrder("", DateTime.Now, 0, 0, "", "", 0, 0, 0);
                    DataTable lotTable = MST.MES.SqlOperations.Kitting.GetKittingTableForLots(new string[] { textBoxLotNumber.Text });
                    Int32 nc12FormatCheck = 0;
                    if (lotTable.Rows.Count > 0)
                    {
                        if (Int32.TryParse(lotTable.Rows[0]["NC12_wyrobu"].ToString(), out nc12FormatCheck))
                        {
                            //load LOT
                            currentOrder.LotNumber = textBoxLotNumber.Text;
                            currentOrder.ModelNc10 = lotTable.Rows[0]["NC12_wyrobu"].ToString();
                            string modelName = MST.MES.SqlOperations.ConnectDB.NC12ToModelName(currentOrder.ModelNc10 + "00");
                            currentOrder.OrderedQty = Int32.Parse(lotTable.Rows[0]["Ilosc_wyrobu_zlecona"].ToString());
                            currentOrder.StartDate = DateTime.Parse(lotTable.Rows[0]["Data_Poczatku_Zlecenia"].ToString());
                            currentOrder.LedsPerModel = int.Parse(lotTable.Rows[0]["IloscDiodNaWyrob"].ToString());
                            currentOrder.BinQty = int.Parse(lotTable.Rows[0]["IloscKIT"].ToString());
                            currentOrder.ModelName = modelName;

                            textBoxLotNumber.Text = "";
                        }
                        else { MessageBox.Show("To nie jest zlecenie MST, model: " + lotTable.Rows[0]["NC12_wyrobu"].ToString()); }
                    }
                    else
                    {
                        //new LOT
                        using (AddNewLot lotForm = new AddNewLot(textBoxLotNumber.Text))
                        {
                            if (lotForm.ShowDialog() == DialogResult.OK)
                            {
                                currentOrder.LotNumber = textBoxLotNumber.Text;
                                currentOrder.ModelNc10 = lotForm.model;
                                currentOrder.OrderedQty = lotForm.orderedQty;
                                currentOrder.StartDate = DateTime.Now;
                                currentOrder.LedsPerModel = lotForm.ledPerModel;
                                currentOrder.BinQty = lotForm.binQty;
                                currentOrder.ModelName = lotForm.modelName;

                                MST.MES.SqlOperations.Kitting.InsertMstOrder(currentOrder.LotNumber, currentOrder.ModelNc10, currentOrder.OrderedQty, currentOrder.StartDate, currentOrder.BinQty, currentOrder.LedsPerModel);
                            }
                        }
                    }

                    UpdateLabels();
                    currentBins = new Dictionary<string, string>();
                    dgvTools.PrepareDgvForBins(dataGridViewLedReels, currentOrder.BinQty);
                    LedReels.AddLedReelsForLot(currentOrder.LotNumber, dataGridViewLedReels, ref currentBins);
                    textBoxLotNumber.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelLotNumber.Text.Length > 6)
            {
                using (AddLedReel ledForm = new AddLedReel(int.Parse(labelBinQty.Text)))
                {
                    if (ledForm.ShowDialog() == DialogResult.OK)
                    {
                        bool binAnd12NCCorrect = true;

                        if (currentBins.ContainsKey(ledForm.binId))
                        {
                            if (ledForm.nc12 != currentBins[ledForm.binId])
                            {
                                binAnd12NCCorrect = false;
                            }
                        }

                        if (binAnd12NCCorrect)
                        {
                            if (release)
                            {
                                MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinId(ledForm.nc12, ledForm.id, currentOrder.LotNumber, ledForm.binId);
                            }

                            LedReels.AddReelToGrid(ledForm.nc12, ledForm.id, dataGridViewLedReels, ref currentBins);
                        }
                        else
                        {
                            string correctBin = "";
                            foreach (var binEntry in currentBins)
                            {
                                if (binEntry.Value == ledForm.nc12)
                                {
                                    correctBin = binEntry.Key;
                                }
                            }
                            MessageBox.Show("Ten numer 12NC diody został przypisany do BINu " + correctBin);
                        }
                    }
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label12NC_TextChanged(object sender, EventArgs e)
        {
            if (label12NC.Text.Length==10)
            {
                label12NC.Text = label12NC.Text.Insert(4, " ").Insert(8, " ");
            }
        }

        private void dataGridViewLedReels_SizeChanged(object sender, EventArgs e)
        {
            dataGridViewLedReels.ClearSelection(); 
        }

        private void dataGridViewLedReels_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewLedReels.ClearSelection();
        }
    }
}
