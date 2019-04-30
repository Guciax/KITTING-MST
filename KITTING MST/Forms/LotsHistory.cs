using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST.Forms
{
    public partial class LotsHistory : Form
    {

        public LotsHistory(bool superUser)
        {
            InitializeComponent();
            this.superUser = superUser;
        }

        bool userEntry = true;

        //DataTable sqlTable = new DataTable();
        Dictionary<string, MST.MES.OrderStructureByOrderNo.Kitting> orders = new Dictionary<string, MST.MES.OrderStructureByOrderNo.Kitting>();
        private readonly bool superUser;

        private void LotsHistory_Load(object sender, EventArgs e)
        {
            //sqlTable = MST.MES.SqlOperations.Kitting.GetMstKittingTable(500);
            orders = MST.MES.SqlDataReaderMethods.Kitting.GetOrdersInfoByDataReader(90);
            //Nr_Zlecenia_Produkcyjnego,NC12_wyrobu,Ilosc_wyrobu_zlecona,Data_Poczatku_Zlecenia,Data_Konca_Zlecenia,IloscKIT,MRM
            userEntry = false;
            FillGrid();
            userEntry = true;
        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var orderEntry in orders)
            {
                if (checkBox1.Checked & orderEntry.Value.endDate > orderEntry.Value.kittingDate) continue;
                if (orderEntry.Value.odredGroup == "LG") continue;
                string endDate = orderEntry.Value.endDate < orderEntry.Value.kittingDate ? "" : orderEntry.Value.endDate.ToString();
                dataGridView1.Rows.Add(orderEntry.Value.orderNo,
                                       orderEntry.Value.modelId_12NCFormat,
                                       orderEntry.Value.ModelName,
                                       orderEntry.Value.orderedQty,
                                       orderEntry.Value.kittingDate,
                                       orderEntry.Value.plannedEndNullable,
                                       endDate,
                                       orderEntry.Value.numberOfBins );
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name== "ColumnModelName")
                {
                    column.Width = 250;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //if (superUser)
                {
                    string endDate = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (endDate == "")
                    {
                        string lotNo = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string model10Nc = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string modelName = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string orderedQty = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string kittingDate = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                        DeleteOrderForm delForm = new DeleteOrderForm(lotNo, model10Nc, modelName, orderedQty, kittingDate);
                        if (delForm.ShowDialog() == DialogResult.OK)
                        {
                            if (MST.MES.SqlOperations.Kitting.DeleteOrder(lotNo))
                            {
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć zakończonego zlecenia.");
                    }
                }
                //else
                {
                    //MessageBox.Show("Brak uprawnień");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        DateTimePicker dtp;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.RowIndex > -1)
            {
                DateTime cellDate = DateTime.Now;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (!DateTime.TryParseExact(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                                                "dd.MM.yyyy",
                                                CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal,
                                                out cellDate))
                    {
                        cellDate = DateTime.Now.AddDays(5);
                    }
                }  
        
                dtp = new DateTimePicker();
                dataGridView1.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Short;
                Rectangle Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                dtp.Location = new Point(Rectangle.X, Rectangle.Y);
                dtp.Value = cellDate;

                dtp.CloseUp += new EventHandler(dtp_CloseUp);
                dtp.TextChanged += new EventHandler(dtp_OnTextChange);

                dtp.Visible = true;
            }
        }
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
            
        }
        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 & e.ColumnIndex == 5 & userEntry) 
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[5];
                if (cell.Value == null) return;
                Debug.WriteLine(cell.Value.ToString());
                string orderNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime plannedEnd = DateTime.ParseExact(cell.Value.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                MST.MES.SqlOperations.Kitting.UpdateOrderPlannedEndDate(orderNo, plannedEnd);
            }
            
        }
    }
}
