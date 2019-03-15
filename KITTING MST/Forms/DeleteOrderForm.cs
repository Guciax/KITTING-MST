using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST.Forms
{
    public partial class DeleteOrderForm : Form
    {
        private readonly string orderNo;
        private readonly string model10Nc;
        private readonly string modelName;
        private readonly string orderedQty;
        private readonly string kittingDate;

        public DeleteOrderForm(string orderNo, string model10Nc, string modelName, string orderedQty, string kittingDate)
        {
            InitializeComponent();
            this.orderNo = orderNo;
            this.model10Nc = model10Nc;
            this.modelName = modelName;
            this.orderedQty = orderedQty;
            this.kittingDate = kittingDate;
        }

        private void DeleteOrderForm_Load(object sender, EventArgs e)
        {
            labelOrderNo.Text += orderNo;
            labelName.Text += modelName;
            label10Nc.Text += model10Nc;
            labelQty.Text += orderedQty;
            labelKittingDate.Text += kittingDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now.ToString()};{Environment.UserName};{orderNo};Usunięcie zlecenie" + Environment.NewLine);
        }
    }
}
