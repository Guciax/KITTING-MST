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


        Dictionary<string, CurrentBinStruct> currentBins = new Dictionary<string, CurrentBinStruct>();
        Dictionary<string, MST.MES.ModelInfo.ModelSpecification> mesModels;
        Dictionary<string, LedOracleSpec> nc12ToOracleSpec;
        Dictionary<string, MST.MES.Data_structures.DevToolsModelStructure> devToolsDb = new Dictionary<string, MST.MES.Data_structures.DevToolsModelStructure>();

        bool release = true;
        string[] userList = new string[] { "piotr.dabrowski", "wojciech.komor", "katarzyna.kustra", "tomasz.jurkin", "grazyna.fabisiak", "mariola.czernis", "kitting.elektronika" };
        string[] superuserList = new string[] { "piotrdabrowski", "wojciech.komor", "katarzyna.kustra" };
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
            mesModels = MST.MES.SqlDataReaderMethods.MesModels.allModels();
            nc12ToOracleSpec = SqlOperations.Nc12ToOracleSpec();
            
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
                        currentBins = new Dictionary<string, CurrentBinStruct>();
                        dgvTools.PrepareDgvForBins(dataGridViewLedReels, (int)currentOrder.numberOfBins);
                        LedReels.AddLedReelsForLot(currentOrder.orderNo, dataGridViewLedReels, ref currentBins, nc12ToOracleSpec);
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
                            if (ledForm.nc12 != currentBins[ledForm.binId].nc12)
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

                            LedReels.AddReelToGrid(ledForm.nc12, ledForm.id, currentOrder.orderNo, dataGridViewLedReels, ref currentBins, nc12ToOracleSpec);
                        }
                        else
                        {
                            string correctBin = "";
                            foreach (var binEntry in currentBins)
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
                    dgvTools.ShowLedDetails(dataGridViewLedReels, e.RowIndex, ref currentBins, currentOrder, nc12ToOracleSpec);
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
            if (currentOrder.orderNo =="" )
            {
                MessageBox.Show("Wczytaj lub utwórz zlecenie");
                return;
            }

            if (!devToolsDb.ContainsKey(currentOrder.modelId + "00"))
            {
                MessageBox.Show("Brak danych w DevTools - wpisz ilości LED ręcznie");
                //........
            }

            Dictionary<string, float> quantityPerCct = new Dictionary<string, float>();
            var dtModel = devToolsDb[$"{currentOrder.modelId}00"];

            bool ledCheck = true;
            Dictionary<string, LedStructForTechnologicSpec> ledForTechCard = new Dictionary<string, LedStructForTechnologicSpec>();
            foreach (var binEntry in currentBins)
            {
                var ledInfo = nc12ToOracleSpec[binEntry.Value.nc12];
                MST.MES.Data_structures.DevToolsModelStructure dtLedInfo;
                devToolsDb.TryGetValue(ledInfo.collective, out dtLedInfo);
                if (!dtModel.qtyPerComponent.ContainsKey(ledInfo.collective))
                {
                    ledCheck = false;
                    break;
                }
                if (!ledForTechCard.ContainsKey(ledInfo.collective))
                {
                    ledForTechCard.Add(ledInfo.collective, new LedStructForTechnologicSpec
                    {
                        collective12NC = ledInfo.collective,
                        qtyPerModel = dtModel.qtyPerComponent[ledInfo.collective],
                        name=binEntry.Value.name
                    });

                    if (dtLedInfo != null)
                    {
                        foreach (var atrEntry in dtLedInfo.atributes)
                        {
                            if (atrEntry.Key.ToUpper().Contains("CCT")){
                                ledForTechCard[ledInfo.collective].CCT = atrEntry.Value;
                            }
                            if (atrEntry.Key.ToUpper().Contains("CRI")){
                                ledForTechCard[ledInfo.collective].CRI = atrEntry.Value;
                            }
                            if (atrEntry.Key.ToUpper().Contains("OBUDOWA")){
                                ledForTechCard[ledInfo.collective].package = atrEntry.Value;
                            }
                        }
                    }
                    
                }

                ledForTechCard[ledInfo.collective].membersList.Add(ledInfo);
            }

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
                }
            }

            var excPkg = ExcelOperations.GetExcelPackage("46TEST");// currentOrder.modelId);
            if (excPkg != null)
            {
                ExcelOperations.FillOutExcelData(currentOrder, ref excPkg, ledForTechCard);
                string tempFile = ExcelOperations.SaveExcelAndReturnPath(excPkg);
                Process.Start(tempFile);
            }
        }

        private void bwDevTools_DoWork(object sender, DoWorkEventArgs e)
        {
            devToolsDb = MST.MES.Data_structures.DevTools.DevToolsLoader.LoadDevToolsModels();
        }

        private void bwDevTools_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonKartaTechnologiczna.Enabled = true;
            buttonKartaTechnologiczna.Text = "Karta technologiczna";
        }
    }
}
