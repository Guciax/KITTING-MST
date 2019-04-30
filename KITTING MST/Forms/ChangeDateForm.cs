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
    public partial class ChangeDateForm : Form
    {
        private readonly MST.MES.OrderStructureByOrderNo.Kitting currentOrder;
        public DateTime selectedDate = new DateTime();

        public ChangeDateForm(MST.MES.OrderStructureByOrderNo.Kitting currentOrder)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
        }

        private void ChangeDateForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Zlecenie: {currentOrder.orderNo}" + Environment.NewLine + $"Data utworzenia: {currentOrder.kittingDate}";
            dateTimePicker1.MinDate = currentOrder.kittingDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MST.MES.SqlOperations.Kitting.UpdateOrderPlannedEndDate(currentOrder.orderNo, dateTimePicker1.Value);
            this.DialogResult = DialogResult.OK;
            selectedDate = dateTimePicker1.Value;
        }
    }
}
