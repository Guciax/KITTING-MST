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
    public partial class EditModel : Form
    {
        public EditModel()
        {
            InitializeComponent();
        }

        private void EditModel_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                var modelInfo = MST.MES.SqlDataReaderMethods.MesModels.mesModel(textBox1.Text);
                if (modelInfo.modelName!=null)
                {
                    numericConnQty.Value = modelInfo.connectorCountPerModel;
                    numericLedsPerModel.Value = modelInfo.pcbCountPerMB;
                    numericLedsPerModel.Value = modelInfo.ledCountPerModel;
                    numericResQty.Value = modelInfo.resistorCountPerModel;
                    labelModelName.Text = modelInfo.modelName;
                }
                else
                {
                    labelModelName.Text = "Brak modelu w bazie!";
                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MST.MES.SqlOperations.MesModels.UpdateMstModel(textBox1.Text, (int)numericLedsPerModel.Value, (int)numericPcbPerMb.Value, (int)numericConnQty.Value, (int)numericResQty.Value);
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int check = 0;
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = (!int.TryParse(e.KeyChar.ToString(), out check) || textBox1.Text.Length > 9);
            }
        }
    }
}
