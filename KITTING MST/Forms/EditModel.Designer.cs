namespace KITTING_MST.Forms
{
    partial class EditModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericPcbPerMb = new System.Windows.Forms.NumericUpDown();
            this.numericResQty = new System.Windows.Forms.NumericUpDown();
            this.numericConnQty = new System.Windows.Forms.NumericUpDown();
            this.numericLedsPerModel = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelModelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPcbPerMb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLedsPerModel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model 10NC:";
            // 
            // numericPcbPerMb
            // 
            this.numericPcbPerMb.Location = new System.Drawing.Point(107, 151);
            this.numericPcbPerMb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPcbPerMb.Name = "numericPcbPerMb";
            this.numericPcbPerMb.Size = new System.Drawing.Size(48, 20);
            this.numericPcbPerMb.TabIndex = 27;
            // 
            // numericResQty
            // 
            this.numericResQty.Location = new System.Drawing.Point(107, 122);
            this.numericResQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericResQty.Name = "numericResQty";
            this.numericResQty.Size = new System.Drawing.Size(48, 20);
            this.numericResQty.TabIndex = 26;
            // 
            // numericConnQty
            // 
            this.numericConnQty.Location = new System.Drawing.Point(107, 93);
            this.numericConnQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericConnQty.Name = "numericConnQty";
            this.numericConnQty.Size = new System.Drawing.Size(48, 20);
            this.numericConnQty.TabIndex = 25;
            // 
            // numericLedsPerModel
            // 
            this.numericLedsPerModel.Location = new System.Drawing.Point(107, 64);
            this.numericLedsPerModel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericLedsPerModel.Name = "numericLedsPerModel";
            this.numericLedsPerModel.Size = new System.Drawing.Size(48, 20);
            this.numericLedsPerModel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ilość rezystorów:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ilość złączek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ilość PCB/MB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ilość LED / wyrób";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "_______________________________________";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Location = new System.Drawing.Point(7, 34);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(16, 13);
            this.labelModelName.TabIndex = 31;
            this.labelModelName.Text = "...";
            // 
            // EditModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 215);
            this.Controls.Add(this.labelModelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPcbPerMb);
            this.Controls.Add(this.numericResQty);
            this.Controls.Add(this.numericConnQty);
            this.Controls.Add(this.numericLedsPerModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditModel";
            this.Text = "EditModel";
            this.Load += new System.EventHandler(this.EditModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPcbPerMb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLedsPerModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPcbPerMb;
        private System.Windows.Forms.NumericUpDown numericResQty;
        private System.Windows.Forms.NumericUpDown numericConnQty;
        private System.Windows.Forms.NumericUpDown numericLedsPerModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelModelName;
    }
}