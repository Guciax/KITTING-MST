using KITTING_MST.DataStructure;
using KITTING_MST.Forms;
using KITTING_MST.Karty_technologiczne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    public partial class Form1 : Form
    {
        MST.MES.OrderStructureByOrderNo.Kitting currentOrder = new MST.MES.OrderStructureByOrderNo.Kitting();

        ///<summary>
        ///BIN letter => LED 12NC
        ///</summary>
        Dictionary<string, string> currentBins = new Dictionary<string, string>();
        Dictionary<string, MST.MES.ModelInfo.ModelSpecification> mesModels;
        Dictionary<string, string> nc12ToName;

        bool release = true;

        string[] userList = new string[] { "piotr.dabrowski", "wojciech.komor", "katarzyna.kustra", "tomasz.jurkin", "grazyna.fabisiak", "mariola.czernis", "kitting.elektronika" };
        string currentUser = Environment.UserName;

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
            mesModels = MST.MES.SqlDataReaderMethods.MesModels.allModels();
            nc12ToName = MST.MES.SqlOperations.ConnectDB.Nc12ToModelFullDict();
        }

        private void UpdateLabels()
        {
            labelLotNumber.Text = currentOrder.orderNo;
            label12NC.Text = currentOrder.modelId_12NCFormat;
            labelOrderedQty.Text = currentOrder.orderedQty.ToString();
            labelStartDate.Text = currentOrder.kittingDate.ToShortDateString();
            
            labelBinQty.Text = currentOrder.numberOfBins.ToString();
            labelModelName.Text = currentOrder.ModelName;

            labelRequiredLeds.Text = (currentOrder.orderedQty * mesModels[currentOrder.modelId].ledCountPerModel).ToString();
            labelLedsPerModel.Text = mesModels[currentOrder.modelId].ledCountPerModel.ToString();
        }

        private void textBoxLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxLotNumber.Text.Length > 5)
            {
                if (e.KeyCode == Keys.Return)
                {
                    currentOrder = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(textBoxLotNumber.Text);

                    if (currentOrder.orderNo == "")
                    {
                        //new order
                        using (AddNewLot lotForm = new AddNewLot(textBoxLotNumber.Text, mesModels))
                        {
                            if (lotForm.ShowDialog() == DialogResult.OK)
                            {
                                currentOrder = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(textBoxLotNumber.Text);
                            }
                        }
                    }

                    textBoxLotNumber.Text = "";

                    if (!string.IsNullOrEmpty(currentOrder.orderNo))
                    {
                        UpdateLabels();
                        currentBins = new Dictionary<string, string>();
                        dgvTools.PrepareDgvForBins(dataGridViewLedReels, (int)currentOrder.numberOfBins);
                        LedReels.AddLedReelsForLot(currentOrder.orderNo, dataGridViewLedReels, ref currentBins);
                        buttonChangeQty.Visible = true;
                    }
                    textBoxLotNumber.Text = "";
                }
            }
        }

        private void butAddLeds_click(object sender, EventArgs e)
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
                                MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinId(ledForm.nc12, ledForm.id, currentOrder.orderNo, ledForm.binId);
                            }

                            LedReels.AddReelToGrid(ledForm.nc12, ledForm.id, currentOrder.orderNo, dataGridViewLedReels, ref currentBins);
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

        private void butOrderHistory_click(object sender, EventArgs e)
        {
            LotsHistory historyForm = new LotsHistory(userList.Contains(currentUser));
            historyForm.Show();
        }

        private void dataGridViewLedReels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1 & e.ColumnIndex>-1)
            {
                if (e.ColumnIndex == 4)
                {
                    if (dataGridViewLedReels.Rows[e.RowIndex].Cells[3].Value != null)
                    {
                        string bin = "";
                        for (int r = e.RowIndex; r >= 0; r--)
                        {
                            if (dataGridViewLedReels.Rows[r].Cells[1].Value.ToString().Contains("BIN"))
                            {
                                bin = dataGridViewLedReels.Rows[r].Cells[1].Value.ToString().Replace("BIN", "").Trim();
                                break;
                            }
                        }
                        string aktZlec = dataGridViewLedReels.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string nc12 = dataGridViewLedReels.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string id = dataGridViewLedReels.Rows[e.RowIndex].Cells[1].Value.ToString();

                        using (EditLedReel editForm = new EditLedReel(currentOrder.orderNo, bin, (int)currentOrder.numberOfBins))
                        {
                            if (editForm.ShowDialog()== DialogResult.OK)
                            {
                                MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinId(nc12, id, editForm.newOrder, editForm.newBin);

                                currentBins = new Dictionary<string, string>();
                                dgvTools.PrepareDgvForBins(dataGridViewLedReels, (int)currentOrder.numberOfBins);
                                LedReels.AddLedReelsForLot(currentOrder.orderNo, dataGridViewLedReels, ref currentBins);
                            }
                        }

                    }
                }
            }
        }

        private void butChangeQty_click(object sender, EventArgs e)
        {
            if (userList.Contains(currentUser))
            {
                using (ChangeOrderQty changeQForm = new ChangeOrderQty((int)currentOrder.orderedQty))
                {
                    if (changeQForm.ShowDialog() == DialogResult.OK)
                    {
                        currentOrder.orderedQty = changeQForm.newQty;

                        MST.MES.SqlOperations.Kitting.UpdateOrderQty(currentOrder.orderNo, (int)currentOrder.orderedQty);
                        UpdateLabels();
                    }
                }
            }
            else MessageBox.Show("Brak uprawnień");
        }

        private void butEditModel_click(object sender, EventArgs e)
        {
            if (userList.Contains(currentUser))
            {
                EditModel editForm = new EditModel();
                editForm.Show();
            }
            else { MessageBox.Show("Brak uprawnień"); }
        }

        private void butKartyTechn_click(object sender, EventArgs e)
        {
            //var dt = MST.MES.Data_structures.DevTools.DevToolsLoader.LoadDevToolsModels();
            //var m = dt["101011710346"];
            //;

            if (currentOrder.orderNo != "")
            {

            }

            currentOrder = new MST.MES.OrderStructureByOrderNo.Kitting
            {
                modelId="model 12NC",
                 ModelName = "nazwa modelu",
                 numberOfBins=2,
                 orderedQty=123
            };

            currentBins.Add("A", "401056013621");//13621
            currentBins.Add("B", "401056015161");//15161
            var excPkg = ExcelOperations.GetExcelPackage("1.xlsx");
            ExcelOperations.FillOutExcelData(currentOrder,ref excPkg, currentBins, nc12ToName);
            string tempFile = ExcelOperations.SaveExcelAndReturnPath(excPkg);
            PrintExcel.SendToPrinter(tempFile);
            Process.Start(tempFile);
        }
    }
}
