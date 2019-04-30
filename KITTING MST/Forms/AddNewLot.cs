using KITTING_MST.DataStructure;
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
        private readonly Dictionary<string, MST.MES.ModelInfo.ModelSpecification> mesModels;
        public string model = "";
        public Int32 orderedQty = 0;
        public int ledPerModel = 0;
        public int binQty = 0;
        public string modelName = "";
        public int connQty = 0;
        public int resQty = 0;
        public int pcbPerMb = 0;
        public bool mesModelUpdated = false;
        bool newModel = false;
        bool modelValuesChanged = false;

        public MST.MES.OrderStructureByOrderNo.Kitting newOrder = new MST.MES.OrderStructureByOrderNo.Kitting();
        public MST.MES.ModelInfo.ModelSpecification mesModel;


        public AddNewLot(string lotNo, Dictionary<string, MST.MES.ModelInfo.ModelSpecification> mesModels)
        {
            InitializeComponent();
            this.lotNo = lotNo;
            this.mesModels = mesModels;
        }

        private void TryLoadModel()
        {
            string nc10 = textBox12NC.Text.Trim().Replace(" ", "");

            //modelName = MST.MES.SqlOperations.ConnectDB.NC12ToModelName(textBox12NC.Text + "00");
            //DataTable modelInfo = MST.MES.SqlOperations.MesModels.GetMstModelInfo(nc10);//MODEL_ID,PKG_SUM_QTY,SMT_Carrier_QTY,Conn_Qty,Resistor_Qty
            if (mesModels.TryGetValue(nc10, out mesModel))
            {
                numericLedsPerModel.Value = mesModel.ledCountPerModel;
                numericPcbPerMb.Value = mesModel.pcbCountPerMB;
                numericConnQty.Value = mesModel.connectorCountPerModel;
                numericResQty.Value = mesModel.resistorCountPerModel;

                newModel = false;
                labelMesInfo.Text = "Model znajduje się w bazie, sprawdź poprawność danych";
                labelMesInfo.ForeColor = Color.Black;
                labelValuesChanged.Visible = false;
                modelName = mesModel.modelName;
            }
            else
            {
                newModel = true;
                labelMesInfo.Text = "Brak modelu w bazie, uzupełnij dane poniżej";
                labelMesInfo.ForeColor = Color.Red;
                modelName = MST.MES.SqlOperations.ConnectDB.NC12ToModelName(nc10 + "00");
            }

            if (modelName == "")
            {
                EditModelNameManually();
            }

            label5.Text = "Nazwa: " + modelName;
        }

        private void textBox12NC_Leave(object sender, EventArgs e)
        {
            TryLoadModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                if (newModel)
                {
                    MST.MES.SqlOperations.MesModels.InsertNewMstModel(textBox12NC.Text, 
                                                                    (int)numericLedsPerModel.Value,
                                                                    (int)numericPcbPerMb.Value,
                                                                    (int)numericConnQty.Value,
                                                                    (int)numericResQty.Value);
                    mesModelUpdated = true;
                }

                if (modelValuesChanged)
                {
                    MST.MES.SqlOperations.MesModels.UpdateMstModel(textBox12NC.Text,
                                                                    (int)numericLedsPerModel.Value,
                                                                    (int)numericPcbPerMb.Value,
                                                                    (int)numericConnQty.Value,
                                                                    (int)numericResQty.Value);
                    mesModelUpdated = true;
                }

                MST.MES.SqlOperations.Kitting.InsertMstOrder(lotNo,
                                                             textBox12NC.Text, 
                                                             int.Parse(textBoxOrderedQty.Text), 
                                                             DateTime.Now, 
                                                             dateTimePickerPlannedEndDate.Value,
                                                             (int)numericBinQty.Value,
                                                             (int)numericLedsPerModel.Value);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void EditModelNameManually()
        {
            using (AddModelNameManually modelNameForm = new AddModelNameManually())
            {
                if (modelNameForm.ShowDialog() == DialogResult.OK)
                {
                    modelName = modelNameForm.modelName;
                }
            }
        }

        private bool CheckForm()
        {
            if (modelName == "") 
            {
                MessageBox.Show("Nieznany numer 10NC wyrobu");
                EditModelNameManually();
                return false;
            }
            if (textBoxOrderedQty.Text=="" || numericBinQty.Value==0 || numericLedsPerModel.Value == 0 || numericPcbPerMb.Value == 0)
            {
                MessageBox.Show("Uzupełnij dane.");
                return false;
            }
            if (numericBinQty.Value < 1)
            {
                MessageBox.Show("Nieprawidłowa ilość BIN.");
                return false;
            }

            return true;
        }

        private void textBox12NC_KeyPress(object sender, KeyPressEventArgs e)
        {
            int check = 0;
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = (!int.TryParse(e.KeyChar.ToString(), out check) || textBox12NC.Text.Length > 9);
            }
            
        }

        private void AddNewLot_Load(object sender, EventArgs e)
        {
            dateTimePickerPlannedEndDate.MinDate = DateTime.Now;
            dateTimePickerPlannedEndDate.Value = DateTime.Now.AddDays(5);
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

        private void textBox12NC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TryLoadModel();
            }
        }

        private void numericLedsPerModel_ValueChanged(object sender, EventArgs e)
        {
            if (!newModel)
            {
                modelValuesChanged = true;
                labelValuesChanged.Visible = true;
            }
        }
    }
}
