namespace EServisRacunara
{
    partial class FormPregledKlijenta
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
            this.lblImeKlijenta = new System.Windows.Forms.Label();
            this.lblTelefonKlijenta = new System.Windows.Forms.Label();
            this.lblAdresaKlijenta = new System.Windows.Forms.Label();
            this.klijentTopbar = new System.Windows.Forms.GroupBox();
            this.listUredjaji = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNazivNapomena = new System.Windows.Forms.Label();
            this.lblNazivDatum = new System.Windows.Forms.Label();
            this.lblNazivCena = new System.Windows.Forms.Label();
            this.lblNazivStatus = new System.Windows.Forms.Label();
            this.lblNazivKvar = new System.Windows.Forms.Label();
            this.lblNazivUredjaj = new System.Windows.Forms.Label();
            this.lblDetaljNapomena = new System.Windows.Forms.Label();
            this.lblDetaljDatum = new System.Windows.Forms.Label();
            this.lblDetaljCena = new System.Windows.Forms.Label();
            this.lblDetaljStatus = new System.Windows.Forms.Label();
            this.lblDetaljKvar = new System.Windows.Forms.Label();
            this.lblDetaljUredjaj = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPromeniStatus = new System.Windows.Forms.Button();
            this.btnPreuzeto = new System.Windows.Forms.Button();
            this.btnObrisiKlijenta = new System.Windows.Forms.Button();
            this.klijentTopbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImeKlijenta
            // 
            this.lblImeKlijenta.AutoSize = true;
            this.lblImeKlijenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblImeKlijenta.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeKlijenta.Location = new System.Drawing.Point(3, 18);
            this.lblImeKlijenta.Name = "lblImeKlijenta";
            this.lblImeKlijenta.Size = new System.Drawing.Size(111, 24);
            this.lblImeKlijenta.TabIndex = 0;
            this.lblImeKlijenta.Text = "Ime Prezime";
            // 
            // lblTelefonKlijenta
            // 
            this.lblTelefonKlijenta.AutoSize = true;
            this.lblTelefonKlijenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTelefonKlijenta.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonKlijenta.Location = new System.Drawing.Point(114, 18);
            this.lblTelefonKlijenta.Name = "lblTelefonKlijenta";
            this.lblTelefonKlijenta.Size = new System.Drawing.Size(70, 24);
            this.lblTelefonKlijenta.TabIndex = 1;
            this.lblTelefonKlijenta.Text = "Telefon";
            // 
            // lblAdresaKlijenta
            // 
            this.lblAdresaKlijenta.AutoSize = true;
            this.lblAdresaKlijenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAdresaKlijenta.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaKlijenta.Location = new System.Drawing.Point(184, 18);
            this.lblAdresaKlijenta.Name = "lblAdresaKlijenta";
            this.lblAdresaKlijenta.Size = new System.Drawing.Size(67, 24);
            this.lblAdresaKlijenta.TabIndex = 2;
            this.lblAdresaKlijenta.Text = "Adresa";
            // 
            // klijentTopbar
            // 
            this.klijentTopbar.Controls.Add(this.lblAdresaKlijenta);
            this.klijentTopbar.Controls.Add(this.lblTelefonKlijenta);
            this.klijentTopbar.Controls.Add(this.lblImeKlijenta);
            this.klijentTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.klijentTopbar.Location = new System.Drawing.Point(0, 0);
            this.klijentTopbar.Name = "klijentTopbar";
            this.klijentTopbar.Size = new System.Drawing.Size(800, 80);
            this.klijentTopbar.TabIndex = 3;
            this.klijentTopbar.TabStop = false;
            // 
            // listUredjaji
            // 
            this.listUredjaji.Dock = System.Windows.Forms.DockStyle.Left;
            this.listUredjaji.FormattingEnabled = true;
            this.listUredjaji.ItemHeight = 16;
            this.listUredjaji.Location = new System.Drawing.Point(0, 80);
            this.listUredjaji.Name = "listUredjaji";
            this.listUredjaji.Size = new System.Drawing.Size(217, 370);
            this.listUredjaji.TabIndex = 4;
            this.listUredjaji.SelectedIndexChanged += new System.EventHandler(this.listUredjaji_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNazivNapomena);
            this.groupBox1.Controls.Add(this.lblNazivDatum);
            this.groupBox1.Controls.Add(this.lblNazivCena);
            this.groupBox1.Controls.Add(this.lblNazivStatus);
            this.groupBox1.Controls.Add(this.lblNazivKvar);
            this.groupBox1.Controls.Add(this.lblNazivUredjaj);
            this.groupBox1.Controls.Add(this.lblDetaljNapomena);
            this.groupBox1.Controls.Add(this.lblDetaljDatum);
            this.groupBox1.Controls.Add(this.lblDetaljCena);
            this.groupBox1.Controls.Add(this.lblDetaljStatus);
            this.groupBox1.Controls.Add(this.lblDetaljKvar);
            this.groupBox1.Controls.Add(this.lblDetaljUredjaj);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(217, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblNazivNapomena
            // 
            this.lblNazivNapomena.AutoSize = true;
            this.lblNazivNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivNapomena.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivNapomena.Location = new System.Drawing.Point(6, 200);
            this.lblNazivNapomena.Name = "lblNazivNapomena";
            this.lblNazivNapomena.Size = new System.Drawing.Size(107, 24);
            this.lblNazivNapomena.TabIndex = 14;
            this.lblNazivNapomena.Text = "Napomena:";
            // 
            // lblNazivDatum
            // 
            this.lblNazivDatum.AutoSize = true;
            this.lblNazivDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivDatum.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivDatum.Location = new System.Drawing.Point(6, 166);
            this.lblNazivDatum.Name = "lblNazivDatum";
            this.lblNazivDatum.Size = new System.Drawing.Size(71, 24);
            this.lblNazivDatum.TabIndex = 13;
            this.lblNazivDatum.Text = "Datum:";
            // 
            // lblNazivCena
            // 
            this.lblNazivCena.AutoSize = true;
            this.lblNazivCena.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivCena.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivCena.Location = new System.Drawing.Point(6, 129);
            this.lblNazivCena.Name = "lblNazivCena";
            this.lblNazivCena.Size = new System.Drawing.Size(60, 24);
            this.lblNazivCena.TabIndex = 12;
            this.lblNazivCena.Text = "Cena:";
            // 
            // lblNazivStatus
            // 
            this.lblNazivStatus.AutoSize = true;
            this.lblNazivStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivStatus.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivStatus.Location = new System.Drawing.Point(6, 92);
            this.lblNazivStatus.Name = "lblNazivStatus";
            this.lblNazivStatus.Size = new System.Drawing.Size(70, 24);
            this.lblNazivStatus.TabIndex = 11;
            this.lblNazivStatus.Text = "Status:";
            // 
            // lblNazivKvar
            // 
            this.lblNazivKvar.AutoSize = true;
            this.lblNazivKvar.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivKvar.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivKvar.Location = new System.Drawing.Point(6, 54);
            this.lblNazivKvar.Name = "lblNazivKvar";
            this.lblNazivKvar.Size = new System.Drawing.Size(54, 24);
            this.lblNazivKvar.TabIndex = 10;
            this.lblNazivKvar.Text = "Kvar:";
            // 
            // lblNazivUredjaj
            // 
            this.lblNazivUredjaj.AutoSize = true;
            this.lblNazivUredjaj.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivUredjaj.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivUredjaj.Location = new System.Drawing.Point(6, 18);
            this.lblNazivUredjaj.Name = "lblNazivUredjaj";
            this.lblNazivUredjaj.Size = new System.Drawing.Size(76, 24);
            this.lblNazivUredjaj.TabIndex = 9;
            this.lblNazivUredjaj.Text = "Uredjaj:";
            // 
            // lblDetaljNapomena
            // 
            this.lblDetaljNapomena.AutoSize = true;
            this.lblDetaljNapomena.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljNapomena.Location = new System.Drawing.Point(119, 200);
            this.lblDetaljNapomena.Name = "lblDetaljNapomena";
            this.lblDetaljNapomena.Size = new System.Drawing.Size(98, 24);
            this.lblDetaljNapomena.TabIndex = 8;
            this.lblDetaljNapomena.Text = "Napomena";
            // 
            // lblDetaljDatum
            // 
            this.lblDetaljDatum.AutoSize = true;
            this.lblDetaljDatum.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljDatum.Location = new System.Drawing.Point(72, 166);
            this.lblDetaljDatum.Name = "lblDetaljDatum";
            this.lblDetaljDatum.Size = new System.Drawing.Size(63, 24);
            this.lblDetaljDatum.TabIndex = 7;
            this.lblDetaljDatum.Text = "Datum";
            // 
            // lblDetaljCena
            // 
            this.lblDetaljCena.AutoSize = true;
            this.lblDetaljCena.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljCena.Location = new System.Drawing.Point(61, 129);
            this.lblDetaljCena.Name = "lblDetaljCena";
            this.lblDetaljCena.Size = new System.Drawing.Size(52, 24);
            this.lblDetaljCena.TabIndex = 6;
            this.lblDetaljCena.Text = "Cena";
            // 
            // lblDetaljStatus
            // 
            this.lblDetaljStatus.AutoSize = true;
            this.lblDetaljStatus.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljStatus.Location = new System.Drawing.Point(73, 92);
            this.lblDetaljStatus.Name = "lblDetaljStatus";
            this.lblDetaljStatus.Size = new System.Drawing.Size(62, 24);
            this.lblDetaljStatus.TabIndex = 5;
            this.lblDetaljStatus.Text = "Status";
            // 
            // lblDetaljKvar
            // 
            this.lblDetaljKvar.AutoSize = true;
            this.lblDetaljKvar.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljKvar.Location = new System.Drawing.Point(55, 54);
            this.lblDetaljKvar.Name = "lblDetaljKvar";
            this.lblDetaljKvar.Size = new System.Drawing.Size(46, 24);
            this.lblDetaljKvar.TabIndex = 4;
            this.lblDetaljKvar.Text = "Kvar";
            // 
            // lblDetaljUredjaj
            // 
            this.lblDetaljUredjaj.AutoSize = true;
            this.lblDetaljUredjaj.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljUredjaj.Location = new System.Drawing.Point(73, 18);
            this.lblDetaljUredjaj.Name = "lblDetaljUredjaj";
            this.lblDetaljUredjaj.Size = new System.Drawing.Size(67, 24);
            this.lblDetaljUredjaj.TabIndex = 3;
            this.lblDetaljUredjaj.Text = "Uredjaj";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiKlijenta);
            this.groupBox2.Controls.Add(this.btnPromeniStatus);
            this.groupBox2.Controls.Add(this.btnPreuzeto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(217, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 120);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnPromeniStatus
            // 
            this.btnPromeniStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromeniStatus.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeniStatus.Location = new System.Drawing.Point(261, 75);
            this.btnPromeniStatus.Name = "btnPromeniStatus";
            this.btnPromeniStatus.Size = new System.Drawing.Size(194, 33);
            this.btnPromeniStatus.TabIndex = 1;
            this.btnPromeniStatus.Text = "Promeni Status";
            this.btnPromeniStatus.UseVisualStyleBackColor = true;
            this.btnPromeniStatus.Click += new System.EventHandler(this.btnPromeniStatus_Click_1);
            // 
            // btnPreuzeto
            // 
            this.btnPreuzeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreuzeto.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreuzeto.Location = new System.Drawing.Point(461, 75);
            this.btnPreuzeto.Name = "btnPreuzeto";
            this.btnPreuzeto.Size = new System.Drawing.Size(110, 33);
            this.btnPreuzeto.TabIndex = 0;
            this.btnPreuzeto.Text = "Preuzeto";
            this.btnPreuzeto.UseVisualStyleBackColor = true;
            this.btnPreuzeto.Click += new System.EventHandler(this.btnPreuzeto_Click_1);
            // 
            // btnObrisiKlijenta
            // 
            this.btnObrisiKlijenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiKlijenta.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKlijenta.Location = new System.Drawing.Point(107, 75);
            this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            this.btnObrisiKlijenta.Size = new System.Drawing.Size(146, 33);
            this.btnObrisiKlijenta.TabIndex = 2;
            this.btnObrisiKlijenta.Text = "Obrisi Klijenta";
            this.btnObrisiKlijenta.UseVisualStyleBackColor = true;
            this.btnObrisiKlijenta.Click += new System.EventHandler(this.btnObrisiKlijenta_Click);
            // 
            // FormPregledKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listUredjaji);
            this.Controls.Add(this.klijentTopbar);
            this.Name = "FormPregledKlijenta";
            this.Text = "FormPregledKlijenta";
            this.klijentTopbar.ResumeLayout(false);
            this.klijentTopbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImeKlijenta;
        private System.Windows.Forms.Label lblTelefonKlijenta;
        private System.Windows.Forms.Label lblAdresaKlijenta;
        private System.Windows.Forms.GroupBox klijentTopbar;
        private System.Windows.Forms.ListBox listUredjaji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetaljNapomena;
        private System.Windows.Forms.Label lblDetaljDatum;
        private System.Windows.Forms.Label lblDetaljCena;
        private System.Windows.Forms.Label lblDetaljStatus;
        private System.Windows.Forms.Label lblDetaljKvar;
        private System.Windows.Forms.Label lblDetaljUredjaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPreuzeto;
        private System.Windows.Forms.Button btnPromeniStatus;
        private System.Windows.Forms.Label lblNazivNapomena;
        private System.Windows.Forms.Label lblNazivDatum;
        private System.Windows.Forms.Label lblNazivCena;
        private System.Windows.Forms.Label lblNazivStatus;
        private System.Windows.Forms.Label lblNazivKvar;
        private System.Windows.Forms.Label lblNazivUredjaj;
        private System.Windows.Forms.Button btnObrisiKlijenta;
    }
}