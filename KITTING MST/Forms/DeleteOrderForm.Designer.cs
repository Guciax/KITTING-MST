namespace KITTING_MST.Forms
{
    partial class DeleteOrderForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrderNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.label10Nc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKittingDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "NIE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 355);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 58);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(563, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "TAK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Potwierdź operację usunięcia zlecenia:";
            // 
            // labelOrderNo
            // 
            this.labelOrderNo.AutoSize = true;
            this.labelOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderNo.Location = new System.Drawing.Point(103, 59);
            this.labelOrderNo.Name = "labelOrderNo";
            this.labelOrderNo.Size = new System.Drawing.Size(96, 26);
            this.labelOrderNo.TabIndex = 3;
            this.labelOrderNo.Text = "Numer:  ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(102, 185);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 26);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nazwa:  ";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQty.Location = new System.Drawing.Point(124, 101);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(75, 26);
            this.labelQty.TabIndex = 5;
            this.labelQty.Text = "Ilość:  ";
            // 
            // label10Nc
            // 
            this.label10Nc.AutoSize = true;
            this.label10Nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10Nc.Location = new System.Drawing.Point(113, 143);
            this.label10Nc.Name = "label10Nc";
            this.label10Nc.Size = new System.Drawing.Size(86, 26);
            this.label10Nc.TabIndex = 6;
            this.label10Nc.Text = "10NC:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tej operacji nie można cofnąć!";
            // 
            // labelKittingDate
            // 
            this.labelKittingDate.AutoSize = true;
            this.labelKittingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKittingDate.Location = new System.Drawing.Point(12, 227);
            this.labelKittingDate.Name = "labelKittingDate";
            this.labelKittingDate.Size = new System.Drawing.Size(187, 26);
            this.labelKittingDate.TabIndex = 8;
            this.labelKittingDate.Text = "Data utworzenia:  ";
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.labelKittingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10Nc);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeleteOrderForm";
            this.Text = "Potwierdzenie usunięcie zlecenia";
            this.Load += new System.EventHandler(this.DeleteOrderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrderNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label label10Nc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKittingDate;
    }
}