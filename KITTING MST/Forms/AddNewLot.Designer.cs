namespace KITTING_MST.Forms
{
    partial class AddNewLot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLotNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox12NC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrderedQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLedQty = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLotNo
            // 
            this.labelLotNo.AutoSize = true;
            this.labelLotNo.Location = new System.Drawing.Point(38, 24);
            this.labelLotNo.Name = "labelLotNo";
            this.labelLotNo.Size = new System.Drawing.Size(86, 13);
            this.labelLotNo.TabIndex = 0;
            this.labelLotNo.Text = "Numer zlecenia: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model 12NC";
            // 
            // textBox12NC
            // 
            this.textBox12NC.Location = new System.Drawing.Point(126, 61);
            this.textBox12NC.Name = "textBox12NC";
            this.textBox12NC.Size = new System.Drawing.Size(156, 20);
            this.textBox12NC.TabIndex = 2;
            this.textBox12NC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12NC_KeyPress);
            this.textBox12NC.Leave += new System.EventHandler(this.textBox12NC_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość wyrobu:";
            // 
            // textBoxOrderedQty
            // 
            this.textBoxOrderedQty.Location = new System.Drawing.Point(126, 101);
            this.textBoxOrderedQty.Name = "textBoxOrderedQty";
            this.textBoxOrderedQty.Size = new System.Drawing.Size(156, 20);
            this.textBoxOrderedQty.TabIndex = 4;
            this.textBoxOrderedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderedQty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość LED / wyrób";
            // 
            // textBoxLedQty
            // 
            this.textBoxLedQty.Location = new System.Drawing.Point(126, 141);
            this.textBoxLedQty.Name = "textBoxLedQty";
            this.textBoxLedQty.Size = new System.Drawing.Size(156, 20);
            this.textBoxLedQty.TabIndex = 6;
            this.textBoxLedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLedQty_KeyPress);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(200, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ilość BIN LD";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 182);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // AddNewLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 257);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLedQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrderedQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox12NC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLotNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewLot";
            this.Text = "AddNewLot";
            this.Load += new System.EventHandler(this.AddNewLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLotNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox12NC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrderedQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLedQty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}