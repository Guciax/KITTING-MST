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
        bool release = true;
        string[] userList = new string[] { "piotr.dabrowski", "wojciech.komor", "katarzyna.kustra", "tomasz.jurkin", "grazyna.fabisiak", "mariola.czernis", "kitting.elektronika" };
        string[] superuserList = new string[] { "piotr.dabrowski", "wojciech.komor", "katarzyna.kustra" };
        string currentUser = Environment.UserName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bwDevTools.RunWorkerAsync();
            #if DEBUG
                //button2.Visible = true;
                //buttonKartaTechnologiczna.Enabled = true;
                release = false;
            #endif
            dataGridViewLedReels.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            DataStorage.mesModels = MST.MES.SqlDataReaderMethods.MesModels.allModels();
            DataStorage.nc12ToOracleSpec = SqlOperations.Nc12ToOracleSpec();
        }

        private void UpdateLabels()
        {
            var currentOrder = DataStorage.currentOrder;
            lpcbPerMb.Text = "";
            var dtModels = DataStorage.devToolsDb.Where(m => m.nc12 == currentOrder.modelId + "00");
            if(dtModels.Count() > 0)
            {
                var dtModel00 = dtModels.First();
                lpcbPerMb.Text = MST.MES.DtTools.GetPcbPerMbCount(dtModel00).ToString();
            }
            

            labelLotNumber.Text = currentOrder.orderNo;
            label12NC.Text = currentOrder.modelId_12NCFormat;
            labelOrderedQty.Text = currentOrder.orderedQty.ToString();
            
            labelBinQty.Text = currentOrder.numberOfBins.ToString();
            labelModelName.Text = currentOrder.ModelName;
            lShippingQty.Text = currentOrder.shippingQty.ToString();

            labelRequiredLeds.Text = (currentOrder.orderedQty * currentOrder.modelSpec.ledCountPerModel).ToString();
            labelLedsPerModel.Text = currentOrder.modelSpec.ledCountPerModel.ToString();

            labelorderStart.Text= currentOrder.kittingDate.ToShortDateString();
            lProdWerehouseStock.Text = "";
            
            if (currentOrder.plannedEnd.Year > 2000) //null = minValue
            {
                labelOrderPlannedEnd.Text = currentOrder.plannedEnd.ToShortDateString();
            }
            else
            {
                labelOrderPlannedEnd.Text = "-";
            }
        }

        private void SetUpComponentsForOrder()
        {
            UpdateLabels();
            DataStorage.currentBins = new Dictionary<string, CurrentBinStruct>();
            dgvTools.PrepareDgvForBins(dataGridViewLedReels, (int)DataStorage.currentOrder.numberOfBins);
            LedReels.AddLedReelsForLot(DataStorage.currentOrder.orderNo, dataGridViewLedReels);
            buttonChangeQty.Visible = true;
            buttonChangePlannedDate.Visible = true;

            var prodWerehoueStock = MST.MES.SqlOperations.ConnectDB.CheckHowManyProductsOnProdWerehouse(DataStorage.currentOrder.modelId + "46");
            if (prodWerehoueStock.Count > 0)
            {
                foreach (var locationEntry in prodWerehoueStock)
                {
                    lProdWerehouseStock.Text += $"{locationEntry.Key} - {locationEntry.Value} szt." + Environment.NewLine;
                }
            }

        }

        private void textBoxLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (textBoxLotNumber.Text.Length > 5 & textBoxLotNumber.Text.Length < 9)
                {
                    if (OrderLoader.OrderExistOrCreatedNewOne(textBoxLotNumber.Text))
                    {
                        SetUpComponentsForOrder();
                    }
                    textBoxLotNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Niepoprawny numer zlecenia.");
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

                        if (DataStorage.currentBins.ContainsKey(ledForm.binId))
                        {
                            if (ledForm.nc12 != DataStorage.currentBins[ledForm.binId].nc12)
                            {
                                binAnd12NCCorrect = false;
                            }
                        }

                        if (binAnd12NCCorrect)
                        {
                            if (release)
                            {
                                MST.MES.SqlOperations.SparingLedInfo.UpdateLedZlecenieStringBinId(ledForm.nc12, ledForm.id, DataStorage.currentOrder.orderNo, ledForm.binId);
                            }

                            LedReels.AddReelToGrid(ledForm.nc12, ledForm.id, DataStorage.currentOrder.orderNo, dataGridViewLedReels);
                        }
                        else
                        {
                            string correctBin = "";
                            foreach (var binEntry in DataStorage.currentBins)
                            {
                                if (binEntry.Value.nc12 == ledForm.nc12)
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
                    dgvTools.ShowLedDetails(dataGridViewLedReels, e.RowIndex);
                }
            }
        }

        private void butChangeQty_click(object sender, EventArgs e)
        {
            if (userList.Contains(currentUser))
            {
                using (ChangeOrderQty changeQForm = new ChangeOrderQty((int)DataStorage.currentOrder.orderedQty, DataStorage.currentOrder.modelId, int.Parse(lpcbPerMb.Text)))
                {
                    if (changeQForm.ShowDialog() == DialogResult.OK)
                    {
                        DataStorage.currentOrder.orderedQty = changeQForm.newQty;

                        MST.MES.SqlOperations.Kitting.UpdateOrderQty(DataStorage.currentOrder.orderNo, (int)DataStorage.currentOrder.orderedQty);
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
            if (DataStorage.currentOrder.orderNo =="" )
            {
                MessageBox.Show("Wczytaj lub utwórz zlecenie");
                return;
            }

            bool ledCheck = true;
            var dtModels = DataStorage.devToolsDb.Where(nc => nc.nc12 == DataStorage.currentOrder.modelId + "00").ToList();
            if (dtModels.Count() == 0) 
            {
                MessageBox.Show("Brak danych w DevTools - wpisz ilości LED ręcznie");
                ledCheck = false;
                //........
            }
            
            Dictionary<string, LedStructForTechnologicSpec> ledForTechCard = DataPreparation.LedForTechCard( ref ledCheck);
            bool nonStandardOrder = false; //false
            if (!ledCheck)
            {
                if (!superuserList.Contains(currentUser))
                {
                    MessageBox.Show("Błąd danych - dioda LED nie neleży do struktury danych." + Environment.NewLine + Environment.NewLine +"Brak uprawnień do stworzenia niestandardowego - tylko Mistrz i Pierwszy Operator");
                    return;
                }

                if (superuserList.Contains(currentUser))
                {
                    MessageBox.Show("Błąd danych - dioda LED nie neleży do struktury danych." + Environment.NewLine + "Należy ręcznie wpisać nazwę, 12NC i ilość diody");
                    nonStandardOrder = true;
                }
            }

            var excPkg = ExcelOperations.GetExcelPackage(DataStorage.currentOrder.modelId);// currentOrder.modelId);
            if (excPkg != null)
            {
                string additionalComment = lProdWerehouseStock.Text != "..." ? $"Wyrób znajduje się na regale: {lProdWerehouseStock.Text}" : "";
                
                ExcelOperations.FillOutExcelData(DataStorage.currentOrder, ref excPkg, ledForTechCard, nonStandardOrder, additionalComment);
                string tempFile = ExcelOperations.SaveExcelAndReturnPath(excPkg);
                Process.Start(tempFile);
            }
        }

        private void bwDevTools_DoWork(object sender, DoWorkEventArgs e)
        {
            DataStorage.devToolsDb = MST.MES.Data_structures.DevTools.DevToolsLoader.LoadDevToolsModels();
        }

        private void bwDevTools_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (DataStorage.devToolsDb.Count > 0)
            {
                buttonKartaTechnologiczna.Enabled = true;
                buttonKartaTechnologiczna.Text = "Karta technologiczna";
            }
            else
            {
                bwDevTools.RunWorkerAsync();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DataStorage.currentOrder.orderNo != "")
            {
                using (ChangeDateForm chDate = new ChangeDateForm(DataStorage.currentOrder.orderNo, DataStorage.currentOrder.kittingDate))
                {
                    if(chDate.ShowDialog() == DialogResult.OK)
                    {
                        DataStorage.currentOrder.plannedEnd = chDate.selectedDate;
                        labelOrderPlannedEnd.Text = DataStorage.currentOrder.plannedEnd.ToShortDateString();
                    }
                }
            }
        }

        private void bNewOrders_Click_1(object sender, EventArgs e)
        {
            using(NewOrder newOrderForm = new NewOrder())
            {
                if (newOrderForm.ShowDialog() == DialogResult.OK)
                {
                    textBoxLotNumber.Text = newOrderForm.selectedOrder;
                    textBoxLotNumber_KeyDown(this, new KeyEventArgs(Keys.Return));
                }
            }
        }
    }
}
