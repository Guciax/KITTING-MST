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
        public string model = "";
        public Int32 orderedQty = 0;
        public int ledPerModel = 0;
        public int binQty = 0;
        public string modelName = "";
        public int connQty = 0;
        public int resQty = 0;
        public int pcbPerMb = 0;
        bool newModel = false;
        bool modelValuesChanged = false;



        public AddNewLot(string lotNo)
        {
            InitializeComponent();
            this.lotNo = lotNo;
        }

        private void TryLoadModel()
        {
            string nc10 = textBox12NC.Text.Trim().Replace(" ", "");
            modelName = MST.MES.SqlOperations.ConnectDB.NC12ToModelName(textBox12NC.Text + "00");
            DataTable modelInfo = MST.MES.SqlOperations.MesModels.GetMstModelInfo(nc10);//MODEL_ID,PKG_SUM_QTY,SMT_Carrier_QTY,Conn_Qty,Resistor_Qty
            if (modelInfo.Rows.Count > 0)
            {
                ledPerModel = int.Parse(modelInfo.Rows[0]["PKG_SUM_QTY"].ToString());
                numericLedsPerModel.Value = ledPerModel;
                pcbPerMb = int.Parse(modelInfo.Rows[0]["SMT_Carrier_QTY"].ToString());
                numericPcbPerMb.Value = pcbPerMb;
                connQty = int.Parse(modelInfo.Rows[0]["Conn_Qty"].ToString());
                numericConnQty.Value = connQty;
                resQty = int.Parse(modelInfo.Rows[0]["Resistor_Qty"].ToString());
                numericResQty.Value = resQty;

                newModel = false;
                labelMesInfo.Text = "Model znajduje się w bazie, sprawdź poprawność danych";
                labelMesInfo.ForeColor = Color.Black;
                labelValuesChanged.Visible = false;
            }
            else
            {
                newModel = true;
                labelMesInfo.Text = "Brak modelu w bazie, wprowadź dane poniżej";
                labelMesInfo.ForeColor = Color.Red;
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
                model = textBox12NC.Text;
                orderedQty = Int32.Parse(textBoxOrderedQty.Text);
                ledPerModel = (int)numericLedsPerModel.Value;
                binQty = (int)numericBinQty.Value;
                pcbPerMb = (int)numericPcbPerMb.Value;
                connQty = (int)numericConnQty.Value;
                resQty = (int)numericResQty.Value;

                if (newModel)
                {
                    MST.MES.SqlOperations.MesModels.InsertNewMstModel(model, ledPerModel, pcbPerMb, connQty, resQty);
                }

                if (modelValuesChanged)
                {
                    MST.MES.SqlOperations.MesModels.UpdateMstModel(model, ledPerModel, pcbPerMb, connQty, resQty);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool CheckForm()
        {
            if (modelName == "")
            {
                MessageBox.Show("Nieznany numer 10NC wyrobu");
                return false;
            }
            if (textBoxOrderedQty.Text=="" || numericBinQty.Value==0 || numericLedsPerModel.Value == 0 || numericPcbPerMb.Value == 0)
            {
                MessageBox.Show("Uzupełnij dane.");
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
