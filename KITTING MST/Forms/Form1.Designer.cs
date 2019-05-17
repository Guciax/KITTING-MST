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
            this.dataGridViewLedReels = new System.Windows.Forms.DataGridView();
            this.NC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonKartaTechnologiczna = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLotNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lProdWerehouseStock = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonChangePlannedDate = new System.Windows.Forms.Button();
            this.labelorderStart = new System.Windows.Forms.Label();
            this.labelOrderPlannedEnd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonChangeQty = new System.Windows.Forms.Button();
            this.labelRequiredLeds = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBinQty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLedsPerModel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOrderedQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLotNumber = new System.Windows.Forms.Label();
            this.label12NC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bwDevTools = new System.ComponentModel.BackgroundWorker();
            this.label15 = new System.Windows.Forms.Label();
            this.lpcbPerMb = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lShippingQty = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLedReels)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLedReels, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 822);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewLedReels
            // 
            this.dataGridViewLedReels.AllowUserToAddRows = false;
            this.dataGridViewLedReels.AllowUserToDeleteRows = false;
            this.dataGridViewLedReels.AllowUserToResizeColumns = false;
            this.dataGridViewLedReels.AllowUserToResizeRows = false;
            this.dataGridViewLedReels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLedReels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NC12,
            this.ID,
            this.Ilosc,
            this.Column1,
            this.Column2});
            this.dataGridViewLedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLedReels.Location = new System.Drawing.Point(3, 413);
            this.dataGridViewLedReels.Name = "dataGridViewLedReels";
            this.dataGridViewLedReels.ReadOnly = true;
            this.dataGridViewLedReels.RowHeadersVisible = false;
            this.dataGridViewLedReels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLedReels.Size = new System.Drawing.Size(461, 356);
            this.dataGridViewLedReels.TabIndex = 3;
            this.dataGridViewLedReels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLedReels_CellContentClick);
            this.dataGridViewLedReels.SelectionChanged += new System.EventHandler(this.dataGridViewLedReels_SelectionChanged);
            this.dataGridViewLedReels.SizeChanged += new System.EventHandler(this.dataGridViewLedReels_SizeChanged);
            // 
            // NC12
            // 
            this.NC12.HeaderText = "12NC";
            this.NC12.Name = "NC12";
            this.NC12.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ilosc
            // 
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Akt.Zlecenie";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edytuj";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonKartaTechnologiczna, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 775);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 44);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(93, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 42);
            this.button4.TabIndex = 26;
            this.button4.TabStop = false;
            this.button4.Text = "Nowe zlecenia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bNewOrders_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "Dodaj diody LED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.butAddLeds_click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(277, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 42);
            this.button3.TabIndex = 24;
            this.button3.TabStop = false;
            this.button3.Text = "Edytuj model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.butEditModel_click);
            // 
            // buttonKartaTechnologiczna
            // 
            this.buttonKartaTechnologiczna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKartaTechnologiczna.Enabled = false;
            this.buttonKartaTechnologiczna.Location = new System.Drawing.Point(185, 1);
            this.buttonKartaTechnologiczna.Margin = new System.Windows.Forms.Padding(1);
            this.buttonKartaTechnologiczna.Name = "buttonKartaTechnologiczna";
            this.buttonKartaTechnologiczna.Size = new System.Drawing.Size(90, 42);
            this.buttonKartaTechnologiczna.TabIndex = 25;
            this.buttonKartaTechnologiczna.TabStop = false;
            this.buttonKartaTechnologiczna.Text = "Wczytywanie danych...";
            this.buttonKartaTechnologiczna.UseVisualStyleBackColor = true;
            this.buttonKartaTechnologiczna.Click += new System.EventHandler(this.butKartyTechn_click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(369, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.Text = "Historia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.butOrderHistory_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBoxLotNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 48);
            this.panel1.TabIndex = 0;
            // 
            // textBoxLotNumber
            // 
            this.textBoxLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLotNumber.Location = new System.Drawing.Point(9, 20);
            this.textBoxLotNumber.Name = "textBoxLotNumber";
            this.textBoxLotNumber.Size = new System.Drawing.Size(440, 23);
            this.textBoxLotNumber.TabIndex = 2;
            this.textBoxLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLotNumber_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numer zlecenia:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lShippingQty);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lpcbPerMb);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lProdWerehouseStock);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.buttonChangePlannedDate);
            this.panel2.Controls.Add(this.labelorderStart);
            this.panel2.Controls.Add(this.labelOrderPlannedEnd);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.buttonChangeQty);
            this.panel2.Controls.Add(this.labelRequiredLeds);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labelModelName);
            this.panel2.Controls.Add(this.labelModel);
            this.panel2.Controls.Add(this.labelBinQty);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelLedsPerModel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelOrderedQty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelLotNumber);
            this.panel2.Controls.Add(this.label12NC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 358);
            this.panel2.TabIndex = 1;
            // 
            // lProdWerehouseStock
            // 
            this.lProdWerehouseStock.AutoSize = true;
            this.lProdWerehouseStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lProdWerehouseStock.Location = new System.Drawing.Point(173, 188);
            this.lProdWerehouseStock.Name = "lProdWerehouseStock";
            this.lProdWerehouseStock.Size = new System.Drawing.Size(20, 17);
            this.lProdWerehouseStock.TabIndex = 31;
            this.lProdWerehouseStock.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(52, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Regał końcówek:";
            // 
            // buttonChangePlannedDate
            // 
            this.buttonChangePlannedDate.Location = new System.Drawing.Point(308, 113);
            this.buttonChangePlannedDate.Name = "buttonChangePlannedDate";
            this.buttonChangePlannedDate.Size = new System.Drawing.Size(141, 23);
            this.buttonChangePlannedDate.TabIndex = 28;
            this.buttonChangePlannedDate.TabStop = false;
            this.buttonChangePlannedDate.Text = "Zmień datę zakończenia";
            this.buttonChangePlannedDate.UseVisualStyleBackColor = true;
            this.buttonChangePlannedDate.Visible = false;
            this.buttonChangePlannedDate.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelorderStart
            // 
            this.labelorderStart.AutoSize = true;
            this.labelorderStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelorderStart.Location = new System.Drawing.Point(173, 100);
            this.labelorderStart.Name = "labelorderStart";
            this.labelorderStart.Size = new System.Drawing.Size(20, 17);
            this.labelorderStart.TabIndex = 27;
            this.labelorderStart.Text = "...";
            // 
            // labelOrderPlannedEnd
            // 
            this.labelOrderPlannedEnd.AutoSize = true;
            this.labelOrderPlannedEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderPlannedEnd.Location = new System.Drawing.Point(173, 119);
            this.labelOrderPlannedEnd.Name = "labelOrderPlannedEnd";
            this.labelOrderPlannedEnd.Size = new System.Drawing.Size(20, 17);
            this.labelOrderPlannedEnd.TabIndex = 26;
            this.labelOrderPlannedEnd.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Planowane zakończenie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(45, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Data rozpoczęcia:";
            // 
            // buttonChangeQty
            // 
            this.buttonChangeQty.Location = new System.Drawing.Point(308, 75);
            this.buttonChangeQty.Name = "buttonChangeQty";
            this.buttonChangeQty.Size = new System.Drawing.Size(141, 23);
            this.buttonChangeQty.TabIndex = 23;
            this.buttonChangeQty.TabStop = false;
            this.buttonChangeQty.Text = "Zmień ilość zlecenia";
            this.buttonChangeQty.UseVisualStyleBackColor = true;
            this.buttonChangeQty.Visible = false;
            this.buttonChangeQty.Click += new System.EventHandler(this.butChangeQty_click);
            // 
            // labelRequiredLeds
            // 
            this.labelRequiredLeds.AutoSize = true;
            this.labelRequiredLeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredLeds.Location = new System.Drawing.Point(152, 303);
            this.labelRequiredLeds.Name = "labelRequiredLeds";
            this.labelRequiredLeds.Size = new System.Drawing.Size(20, 17);
            this.labelRequiredLeds.TabIndex = 21;
            this.labelRequiredLeds.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Potrzebna Ilość LED:";
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModelName.Location = new System.Drawing.Point(173, 43);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(20, 17);
            this.labelModelName.TabIndex = 18;
            this.labelModelName.Text = "...";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(63, 43);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(104, 17);
            this.labelModel.TabIndex = 17;
            this.labelModel.Text = "Nazwa modelu:";
            // 
            // labelBinQty
            // 
            this.labelBinQty.AutoSize = true;
            this.labelBinQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBinQty.Location = new System.Drawing.Point(396, 336);
            this.labelBinQty.Name = "labelBinQty";
            this.labelBinQty.Size = new System.Drawing.Size(20, 17);
            this.labelBinQty.TabIndex = 16;
            this.labelBinQty.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(296, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ilość BIN LED:";
            // 
            // labelLedsPerModel
            // 
            this.labelLedsPerModel.AutoSize = true;
            this.labelLedsPerModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLedsPerModel.Location = new System.Drawing.Point(173, 138);
            this.labelLedsPerModel.Name = "labelLedsPerModel";
            this.labelLedsPerModel.Size = new System.Drawing.Size(20, 17);
            this.labelLedsPerModel.TabIndex = 13;
            this.labelLedsPerModel.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(87, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "LED/wyrób:";
            // 
            // labelOrderedQty
            // 
            this.labelOrderedQty.AutoSize = true;
            this.labelOrderedQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderedQty.Location = new System.Drawing.Point(173, 81);
            this.labelOrderedQty.Name = "labelOrderedQty";
            this.labelOrderedQty.Size = new System.Drawing.Size(20, 17);
            this.labelOrderedQty.TabIndex = 10;
            this.labelOrderedQty.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(74, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ilość zlecona:";
            // 
            // labelLotNumber
            // 
            this.labelLotNumber.AutoSize = true;
            this.labelLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLotNumber.Location = new System.Drawing.Point(173, 5);
            this.labelLotNumber.Name = "labelLotNumber";
            this.labelLotNumber.Size = new System.Drawing.Size(20, 17);
            this.labelLotNumber.TabIndex = 5;
            this.labelLotNumber.Text = "...";
            // 
            // label12NC
            // 
            this.label12NC.AutoSize = true;
            this.label12NC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12NC.Location = new System.Drawing.Point(173, 24);
            this.label12NC.Name = "label12NC";
            this.label12NC.Size = new System.Drawing.Size(20, 17);
            this.label12NC.TabIndex = 4;
            this.label12NC.Text = "...";
            this.label12NC.TextChanged += new System.EventHandler(this.label12NC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diody LED do zlecenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr zlecenia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model 10NC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "___________________________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(409, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "___________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "___________________________________________________________________";
            // 
            // bwDevTools
            // 
            this.bwDevTools.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDevTools_DoWork);
            this.bwDevTools.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDevTools_RunWorkerCompleted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(104, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "PCB/MB:";
            // 
            // lpcbPerMb
            // 
            this.lpcbPerMb.AutoSize = true;
            this.lpcbPerMb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lpcbPerMb.Location = new System.Drawing.Point(173, 157);
            this.lpcbPerMb.Name = "lpcbPerMb";
            this.lpcbPerMb.Size = new System.Drawing.Size(20, 17);
            this.lpcbPerMb.TabIndex = 33;
            this.lpcbPerMb.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(60, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Ilość do wysyłki:";
            // 
            // lShippingQty
            // 
            this.lShippingQty.AutoSize = true;
            this.lShippingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lShippingQty.Location = new System.Drawing.Point(173, 62);
            this.lShippingQty.Name = "lShippingQty";
            this.lShippingQty.Size = new System.Drawing.Size(20, 17);
            this.lShippingQty.TabIndex = 35;
            this.lShippingQty.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 822);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "KITTING MST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLedReels)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLedsPerModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelBinQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelRequiredLeds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button buttonChangeQty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonKartaTechnologiczna;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.ComponentModel.BackgroundWorker bwDevTools;
        private System.Windows.Forms.Button buttonChangePlannedDate;
        private System.Windows.Forms.Label labelorderStart;
        private System.Windows.Forms.Label labelOrderPlannedEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lProdWerehouseStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lpcbPerMb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lShippingQty;
        private System.Windows.Forms.Label label16;
    }
}

