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
    public partial class LotsHistory : Form
    {

        public LotsHistory()
        {
            InitializeComponent();

        }

        private void LotsHistory_Load(object sender, EventArgs e)
        {
            var sqlTable = MST.MES.SqlOperations.Kitting.GetMstKittingTable(500);
            //Nr_Zlecenia_Produkcyjnego,NC12_wyrobu,Ilosc_wyrobu_zlecona,Data_Poczatku_Zlecenia,IloscKIT
            //dataGridView1.Columns["Nr_Zlecenia_Produkcyjnego"].HeaderText = "Nr zlecenia";
            //dataGridView1.Columns["NC12_wyrobu"].HeaderText = "10NC";
            //dataGridView1.Columns["Ilosc_wyrobu_zlecona"].HeaderText = "Ilość";
            //dataGridView1.Columns["Data_Poczatku_Zlecenia"].HeaderText = "Data";
            //dataGridView1.Columns["IloscKIT"].HeaderText = "Ilość BIN";

            foreach (DataRow row in sqlTable.Rows)
            {
                object[] newRow = row.ItemArray;
                newRow[newRow.Length - 1] = "";
                dataGridView1.Rows.Add(newRow);

            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string lotNo = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"Uwaga zlecenie {lotNo} zostanie usunięte. Tej operacji nie można cofnąc!", "UWAGA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MST.MES.SqlOperations.Kitting.DeleteOrder(lotNo))
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
                

            }
        }
    }
}
