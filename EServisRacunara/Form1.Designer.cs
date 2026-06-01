namespace EServisRacunara
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
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnDodajUredjaj = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUredjaji = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.PictureBox();
            this.tableKorisnici = new System.Windows.Forms.DataGridView();
            this.tableUredjaji = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pocetnaKartice = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUToku = new System.Windows.Forms.Label();
            this.lblPrimljeno = new System.Windows.Forms.Label();
            this.lblZavrseno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataPocetna = new System.Windows.Forms.DataGridView();
            this.txtPretragaKlijenata = new System.Windows.Forms.TextBox();
            this.txtPretragaUredjaja = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUredjaji)).BeginInit();
            this.pocetnaKartice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPocetna)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.txtPretragaUredjaja);
            groupBox1.Controls.Add(this.txtPretragaKlijenata);
            groupBox1.Controls.Add(this.lblNaslov);
            groupBox1.Controls.Add(this.btnDodajUredjaj);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(185, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(877, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Inter", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(354, 16);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(208, 62);
            this.lblNaslov.TabIndex = 3;
            this.lblNaslov.Text = "E-Servis";
            // 
            // btnDodajUredjaj
            // 
            this.btnDodajUredjaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajUredjaj.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUredjaj.Location = new System.Drawing.Point(597, 43);
            this.btnDodajUredjaj.Name = "btnDodajUredjaj";
            this.btnDodajUredjaj.Size = new System.Drawing.Size(211, 35);
            this.btnDodajUredjaj.TabIndex = 5;
            this.btnDodajUredjaj.Text = "Dodaj Novi Uređaj";
            this.btnDodajUredjaj.UseVisualStyleBackColor = true;
            this.btnDodajUredjaj.Click += new System.EventHandler(this.btnDodajUredjaj_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sideBar.Controls.Add(this.pictureBox1);
            this.sideBar.Controls.Add(this.pictureBox2);
            this.sideBar.Controls.Add(this.pictureBox3);
            this.sideBar.Controls.Add(this.btnUredjaji);
            this.sideBar.Controls.Add(this.btnKlijenti);
            this.sideBar.Controls.Add(this.btnPocetna);
            this.sideBar.Controls.Add(this.btnHamburger);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(185, 531);
            this.sideBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnUredjaji
            // 
            this.btnUredjaji.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUredjaji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredjaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUredjaji.FlatAppearance.BorderSize = 0;
            this.btnUredjaji.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUredjaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredjaji.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredjaji.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUredjaji.Location = new System.Drawing.Point(0, 141);
            this.btnUredjaji.Name = "btnUredjaji";
            this.btnUredjaji.Size = new System.Drawing.Size(185, 51);
            this.btnUredjaji.TabIndex = 3;
            this.btnUredjaji.Text = "Uredjaji";
            this.btnUredjaji.UseVisualStyleBackColor = false;
            this.btnUredjaji.Click += new System.EventHandler(this.btnUredjaji_Click);
            this.btnUredjaji.MouseEnter += new System.EventHandler(this.btnUredjaji_MouseEnter);
            this.btnUredjaji.MouseLeave += new System.EventHandler(this.btnUredjaji_MouseLeave);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKlijenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKlijenti.FlatAppearance.BorderSize = 0;
            this.btnKlijenti.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlijenti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKlijenti.Location = new System.Drawing.Point(0, 90);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(185, 51);
            this.btnKlijenti.TabIndex = 2;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = false;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            this.btnKlijenti.MouseEnter += new System.EventHandler(this.btnKlijenti_MouseEnter);
            this.btnKlijenti.MouseLeave += new System.EventHandler(this.btnKlijenti_MouseLeave);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPocetna.Location = new System.Drawing.Point(0, 39);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(185, 51);
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // btnHamburger
            // 
            this.btnHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHamburger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHamburger.Image = ((System.Drawing.Image)(resources.GetObject("btnHamburger.Image")));
            this.btnHamburger.Location = new System.Drawing.Point(0, 0);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(185, 39);
            this.btnHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHamburger.TabIndex = 0;
            this.btnHamburger.TabStop = false;
            this.btnHamburger.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableKorisnici
            // 
            this.tableKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableKorisnici.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tableKorisnici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKorisnici.Location = new System.Drawing.Point(185, 262);
            this.tableKorisnici.Name = "tableKorisnici";
            this.tableKorisnici.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableKorisnici.RowHeadersWidth = 51;
            this.tableKorisnici.RowTemplate.Height = 24;
            this.tableKorisnici.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKorisnici.Size = new System.Drawing.Size(877, 269);
            this.tableKorisnici.TabIndex = 6;
            this.tableKorisnici.Visible = false;
            this.tableKorisnici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableKorisnici_CellContentDoubleClick);
            this.tableKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableKorisnici_CellDoubleClick);
            // 
            // tableUredjaji
            // 
            this.tableUredjaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUredjaji.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tableUredjaji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableUredjaji.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableUredjaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUredjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.tableUredjaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUredjaji.Location = new System.Drawing.Point(185, 262);
            this.tableUredjaji.Name = "tableUredjaji";
            this.tableUredjaji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableUredjaji.RowHeadersWidth = 51;
            this.tableUredjaji.RowTemplate.Height = 24;
            this.tableUredjaji.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableUredjaji.Size = new System.Drawing.Size(877, 269);
            this.tableUredjaji.TabIndex = 8;
            this.tableUredjaji.Visible = false;
            this.tableUredjaji.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tableUredjaji_CellBeginEdit);
            this.tableUredjaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUredjaji_CellContentClick);
            this.tableUredjaji.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUredjaji_CellValueChanged);
            this.tableUredjaji.CurrentCellDirtyStateChanged += new System.EventHandler(this.tableUredjaji_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn1.HeaderText = "Menjanje";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "Promeni";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewButtonColumn2.HeaderText = "Brisanje";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Obrisi";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 281;
            // 
            // pocetnaKartice
            // 
            this.pocetnaKartice.Controls.Add(this.groupBox2);
            this.pocetnaKartice.Controls.Add(this.label1);
            this.pocetnaKartice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pocetnaKartice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pocetnaKartice.Location = new System.Drawing.Point(185, 84);
            this.pocetnaKartice.Name = "pocetnaKartice";
            this.pocetnaKartice.Size = new System.Drawing.Size(877, 178);
            this.pocetnaKartice.TabIndex = 11;
            this.pocetnaKartice.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUToku);
            this.groupBox2.Controls.Add(this.lblPrimljeno);
            this.groupBox2.Controls.Add(this.lblZavrseno);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 103);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // lblUToku
            // 
            this.lblUToku.AutoSize = true;
            this.lblUToku.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUToku.Font = new System.Drawing.Font("Inter SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUToku.Location = new System.Drawing.Point(674, 18);
            this.lblUToku.Margin = new System.Windows.Forms.Padding(3, 0, 100, 0);
            this.lblUToku.Name = "lblUToku";
            this.lblUToku.Size = new System.Drawing.Size(194, 53);
            this.lblUToku.TabIndex = 12;
            this.lblUToku.Text = "0 Uređaja";
            // 
            // lblPrimljeno
            // 
            this.lblPrimljeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrimljeno.AutoSize = true;
            this.lblPrimljeno.Font = new System.Drawing.Font("Inter SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimljeno.Location = new System.Drawing.Point(365, 18);
            this.lblPrimljeno.Margin = new System.Windows.Forms.Padding(3, 0, 100, 0);
            this.lblPrimljeno.Name = "lblPrimljeno";
            this.lblPrimljeno.Size = new System.Drawing.Size(194, 53);
            this.lblPrimljeno.TabIndex = 11;
            this.lblPrimljeno.Text = "0 Uređaja";
            // 
            // lblZavrseno
            // 
            this.lblZavrseno.AutoSize = true;
            this.lblZavrseno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblZavrseno.Font = new System.Drawing.Font("Inter SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZavrseno.Location = new System.Drawing.Point(3, 18);
            this.lblZavrseno.Margin = new System.Windows.Forms.Padding(3, 0, 100, 0);
            this.lblZavrseno.Name = "lblZavrseno";
            this.lblZavrseno.Size = new System.Drawing.Size(194, 53);
            this.lblZavrseno.TabIndex = 13;
            this.lblZavrseno.Text = "0 Uređaja";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status Popravki";
            // 
            // dataPocetna
            // 
            this.dataPocetna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPocetna.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataPocetna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPocetna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPocetna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPocetna.Location = new System.Drawing.Point(185, 262);
            this.dataPocetna.Name = "dataPocetna";
            this.dataPocetna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPocetna.RowHeadersWidth = 51;
            this.dataPocetna.RowTemplate.Height = 24;
            this.dataPocetna.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPocetna.Size = new System.Drawing.Size(877, 269);
            this.dataPocetna.TabIndex = 12;
            // 
            // txtPretragaKlijenata
            // 
            this.txtPretragaKlijenata.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaKlijenata.Location = new System.Drawing.Point(15, 45);
            this.txtPretragaKlijenata.Name = "txtPretragaKlijenata";
            this.txtPretragaKlijenata.Size = new System.Drawing.Size(185, 28);
            this.txtPretragaKlijenata.TabIndex = 6;
            this.txtPretragaKlijenata.Text = "Pretraga...";
            this.txtPretragaKlijenata.Visible = false;
            this.txtPretragaKlijenata.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPretragaKlijenata_MouseClick);
            this.txtPretragaKlijenata.TextChanged += new System.EventHandler(this.txtPretragaKlijenata_TextChanged);
            // 
            // txtPretragaUredjaja
            // 
            this.txtPretragaUredjaja.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaUredjaja.Location = new System.Drawing.Point(15, 45);
            this.txtPretragaUredjaja.Name = "txtPretragaUredjaja";
            this.txtPretragaUredjaja.Size = new System.Drawing.Size(185, 28);
            this.txtPretragaUredjaja.TabIndex = 7;
            this.txtPretragaUredjaja.Text = "Pretraga...";
            this.txtPretragaUredjaja.Visible = false;
            this.txtPretragaUredjaja.Click += new System.EventHandler(this.txtPretragaUredjaja_Click);
            this.txtPretragaUredjaja.TextChanged += new System.EventHandler(this.txtPretragaUredjaja_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 531);
            this.Controls.Add(this.dataPocetna);
            this.Controls.Add(this.tableKorisnici);
            this.Controls.Add(this.tableUredjaji);
            this.Controls.Add(this.pocetnaKartice);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.sideBar);
            this.Name = "Form1";
            this.Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUredjaji)).EndInit();
            this.pocetnaKartice.ResumeLayout(false);
            this.pocetnaKartice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPocetna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox btnHamburger;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnUredjaji;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnDodajUredjaj;
        private System.Windows.Forms.DataGridView tableKorisnici;
        private System.Windows.Forms.DataGridView tableUredjaji;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.GroupBox pocetnaKartice;
        private System.Windows.Forms.Label lblZavrseno;
        private System.Windows.Forms.Label lblUToku;
        private System.Windows.Forms.Label lblPrimljeno;
        private System.Windows.Forms.DataGridView dataPocetna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPretragaKlijenata;
        private System.Windows.Forms.TextBox txtPretragaUredjaja;
    }
}

