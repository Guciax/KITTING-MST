namespace KITTING_MST
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOrderedQty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLotNumber = new System.Windows.Forms.Label();
            this.label12NC = new System.Windows.Forms.Label();
            this.dataGridViewLedReels = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLotNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLedsPerModel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLedReels)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.labelLedsPerModel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelStartDate);
            this.panel2.Controls.Add(this.labelOrderedQty);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelLotNumber);
            this.panel2.Controls.Add(this.label12NC);
            this.panel2.Controls.Add(this.dataGridViewLedReels);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 499);
            this.panel2.TabIndex = 1;
            // 
            // labelOrderedQty
            // 
            this.labelOrderedQty.AutoSize = true;
            this.labelOrderedQty.Location = new System.Drawing.Point(91, 39);
            this.labelOrderedQty.Name = "labelOrderedQty";
            this.labelOrderedQty.Size = new System.Drawing.Size(16, 13);
            this.labelOrderedQty.TabIndex = 10;
            this.labelOrderedQty.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data zlecenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ilość zlecona:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj diody LED ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLotNumber
            // 
            this.labelLotNumber.AutoSize = true;
            this.labelLotNumber.Location = new System.Drawing.Point(91, 22);
            this.labelLotNumber.Name = "labelLotNumber";
            this.labelLotNumber.Size = new System.Drawing.Size(16, 13);
            this.labelLotNumber.TabIndex = 5;
            this.labelLotNumber.Text = "...";
            // 
            // label12NC
            // 
            this.label12NC.AutoSize = true;
            this.label12NC.Location = new System.Drawing.Point(91, 5);
            this.label12NC.Name = "label12NC";
            this.label12NC.Size = new System.Drawing.Size(16, 13);
            this.label12NC.TabIndex = 4;
            this.label12NC.Text = "...";
            // 
            // dataGridViewLedReels
            // 
            this.dataGridViewLedReels.AllowUserToAddRows = false;
            this.dataGridViewLedReels.AllowUserToDeleteRows = false;
            this.dataGridViewLedReels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLedReels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NC12,
            this.ID,
            this.Ilosc});
            this.dataGridViewLedReels.Location = new System.Drawing.Point(4, 125);
            this.dataGridViewLedReels.Name = "dataGridViewLedReels";
            this.dataGridViewLedReels.RowHeadersVisible = false;
            this.dataGridViewLedReels.Size = new System.Drawing.Size(416, 331);
            this.dataGridViewLedReels.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diody LED do zlecenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr zlecenia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model 12NC:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBoxLotNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 44);
            this.panel1.TabIndex = 0;
            // 
            // textBoxLotNumber
            // 
            this.textBoxLotNumber.Location = new System.Drawing.Point(9, 19);
            this.textBoxLotNumber.Name = "textBoxLotNumber";
            this.textBoxLotNumber.Size = new System.Drawing.Size(411, 20);
            this.textBoxLotNumber.TabIndex = 2;
            this.textBoxLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLotNumber_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numer zlecenia:";
            // 
            // NC12
            // 
            this.NC12.HeaderText = "12NC";
            this.NC12.Name = "NC12";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ilosc
            // 
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(90, 74);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(16, 13);
            this.labelStartDate.TabIndex = 11;
            this.labelStartDate.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "LED/wyrób:";
            // 
            // labelLedsPerModel
            // 
            this.labelLedsPerModel.AutoSize = true;
            this.labelLedsPerModel.Location = new System.Drawing.Point(91, 56);
            this.labelLedsPerModel.Name = "labelLedsPerModel";
            this.labelLedsPerModel.Size = new System.Drawing.Size(16, 13);
            this.labelLedsPerModel.TabIndex = 13;
            this.labelLedsPerModel.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "___________________________________________________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "KITTING MST";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLedReels)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLotNumber;
        private System.Windows.Forms.Label label12NC;
        private System.Windows.Forms.DataGridView dataGridViewLedReels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLotNumber;
        private System.Windows.Forms.Label labelOrderedQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelLedsPerModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

