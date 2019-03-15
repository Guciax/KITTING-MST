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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBinQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericLedsPerModel = new System.Windows.Forms.NumericUpDown();
            this.numericConnQty = new System.Windows.Forms.NumericUpDown();
            this.numericResQty = new System.Windows.Forms.NumericUpDown();
            this.numericPcbPerMb = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMesInfo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelValuesChanged = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericBinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLedsPerModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPcbPerMb)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLotNo
            // 
            this.labelLotNo.AutoSize = true;
            this.labelLotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLotNo.Location = new System.Drawing.Point(10, 5);
            this.labelLotNo.Name = "labelLotNo";
            this.labelLotNo.Size = new System.Drawing.Size(176, 26);
            this.labelLotNo.TabIndex = 0;
            this.labelLotNo.Text = "Numer zlecenia: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model 10NC";
            // 
            // textBox12NC
            // 
            this.textBox12NC.Location = new System.Drawing.Point(81, 39);
            this.textBox12NC.Name = "textBox12NC";
            this.textBox12NC.Size = new System.Drawing.Size(156, 20);
            this.textBox12NC.TabIndex = 2;
            this.textBox12NC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox12NC_KeyDown);
            this.textBox12NC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12NC_KeyPress);
            this.textBox12NC.Leave += new System.EventHandler(this.textBox12NC_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość wyrobu:";
            // 
            // textBoxOrderedQty
            // 
            this.textBoxOrderedQty.Location = new System.Drawing.Point(81, 80);
            this.textBoxOrderedQty.Name = "textBoxOrderedQty";
            this.textBoxOrderedQty.Size = new System.Drawing.Size(156, 20);
            this.textBoxOrderedQty.TabIndex = 4;
            this.textBoxOrderedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderedQty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość LED / wyrób";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ilość BIN LD";
            // 
            // numericBinQty
            // 
            this.numericBinQty.Location = new System.Drawing.Point(81, 107);
            this.numericBinQty.Name = "numericBinQty";
            this.numericBinQty.Size = new System.Drawing.Size(48, 20);
            this.numericBinQty.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nazwa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "___________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ilość PCB/MB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ilość złączek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ilość rezystorów:";
            // 
            // numericLedsPerModel
            // 
            this.numericLedsPerModel.Location = new System.Drawing.Point(107, 190);
            this.numericLedsPerModel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericLedsPerModel.Name = "numericLedsPerModel";
            this.numericLedsPerModel.Size = new System.Drawing.Size(48, 20);
            this.numericLedsPerModel.TabIndex = 16;
            this.numericLedsPerModel.ValueChanged += new System.EventHandler(this.numericLedsPerModel_ValueChanged);
            // 
            // numericConnQty
            // 
            this.numericConnQty.Location = new System.Drawing.Point(107, 219);
            this.numericConnQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericConnQty.Name = "numericConnQty";
            this.numericConnQty.Size = new System.Drawing.Size(48, 20);
            this.numericConnQty.TabIndex = 17;
            this.numericConnQty.ValueChanged += new System.EventHandler(this.numericLedsPerModel_ValueChanged);
            // 
            // numericResQty
            // 
            this.numericResQty.Location = new System.Drawing.Point(107, 248);
            this.numericResQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericResQty.Name = "numericResQty";
            this.numericResQty.Size = new System.Drawing.Size(48, 20);
            this.numericResQty.TabIndex = 18;
            this.numericResQty.ValueChanged += new System.EventHandler(this.numericLedsPerModel_ValueChanged);
            // 
            // numericPcbPerMb
            // 
            this.numericPcbPerMb.Location = new System.Drawing.Point(107, 277);
            this.numericPcbPerMb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPcbPerMb.Name = "numericPcbPerMb";
            this.numericPcbPerMb.Size = new System.Drawing.Size(48, 20);
            this.numericPcbPerMb.TabIndex = 19;
            this.numericPcbPerMb.ValueChanged += new System.EventHandler(this.numericLedsPerModel_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(11, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Każde 12NC diody to oddzielny BIN";
            // 
            // labelMesInfo
            // 
            this.labelMesInfo.AutoSize = true;
            this.labelMesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMesInfo.Location = new System.Drawing.Point(11, 165);
            this.labelMesInfo.Name = "labelMesInfo";
            this.labelMesInfo.Size = new System.Drawing.Size(16, 13);
            this.labelMesInfo.TabIndex = 21;
            this.labelMesInfo.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "___________________________________________________";
            // 
            // labelValuesChanged
            // 
            this.labelValuesChanged.AutoSize = true;
            this.labelValuesChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValuesChanged.Location = new System.Drawing.Point(12, 303);
            this.labelValuesChanged.Name = "labelValuesChanged";
            this.labelValuesChanged.Size = new System.Drawing.Size(183, 13);
            this.labelValuesChanged.TabIndex = 23;
            this.labelValuesChanged.Text = "Zmienione wartości zostaną zapisane";
            this.labelValuesChanged.Visible = false;
            // 
            // AddNewLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 365);
            this.Controls.Add(this.labelValuesChanged);
            this.Controls.Add(this.labelMesInfo);
            this.Controls.Add(this.numericPcbPerMb);
            this.Controls.Add(this.numericResQty);
            this.Controls.Add(this.numericConnQty);
            this.Controls.Add(this.numericLedsPerModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericBinQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrderedQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox12NC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLotNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewLot";
            this.Text = "Dodaj nowe zlecenie";
            this.Load += new System.EventHandler(this.AddNewLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLedsPerModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPcbPerMb)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBinQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericLedsPerModel;
        private System.Windows.Forms.NumericUpDown numericConnQty;
        private System.Windows.Forms.NumericUpDown numericResQty;
        private System.Windows.Forms.NumericUpDown numericPcbPerMb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMesInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelValuesChanged;
    }
}