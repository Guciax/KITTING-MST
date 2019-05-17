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
        private readonly string currentOrderNumber;
        private readonly DateTime kittingDate;
        public DateTime selectedDate = new DateTime();

        public ChangeDateForm(string currentOrderNumber, DateTime kittingDate)
        {
            InitializeComponent();
            this.currentOrderNumber = currentOrderNumber;
            this.kittingDate = kittingDate;
        }

        private void ChangeDateForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Aktualne Zlecenie: {currentOrderNumber}" + Environment.NewLine + $"Data utworzenia: {kittingDate}" + Environment.NewLine + "Wybierz nową datę:";
            monthCalendar1.MinDate = kittingDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDate = monthCalendar1.SelectionStart.Date;
            MST.MES.SqlOperations.Kitting.UpdateOrderPlannedEndDate(currentOrderNumber, selectedDate);
            this.DialogResult = DialogResult.OK;
        }
    }
}
