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
    public partial class NewOrder : Form
    {
        public string selectedOrder = "";
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            var mstOrders = MST.MES.SqlDataReaderMethods.Kitting.GetKittingDataForClientGroup(MST.MES.SqlDataReaderMethods.Kitting.clientGroup.MST, 15);
            var newOrders = mstOrders.Where(o => o.Value.orderedQty == -1);

            foreach (var orderEntry in newOrders)
            {
                dataGridView1.Rows.Add(orderEntry.Key, "Wczytaj");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1 & e.ColumnIndex == 1)
            {
                selectedOrder = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
