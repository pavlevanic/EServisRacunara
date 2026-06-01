using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EServisRacunara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableUredjaji.DataError += (s, e) => { };
            tableUredjaji.CurrentCellDirtyStateChanged += tableUredjaji_CurrentCellDirtyStateChanged;
            tableUredjaji.CellValueChanged += tableUredjaji_CellValueChanged;
            UcitajStatistiku();
            UcitajPocetnu();
        }

        private void UcitajStatistiku()
        {
            DataTable dt = BazaPodataka.GetStatistika();

            lblPrimljeno.Text = "Primljeno: 0";
            lblUToku.Text = "U toku: 0";
            lblZavrseno.Text = "Zavrseno: 0";

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                string broj = row["Broj uređaja"].ToString();

                switch (status)
                {
                    case "primljeno": lblPrimljeno.Text = "Primljeno: " + broj; break;
                    case "u toku": lblUToku.Text = "U toku: " + broj; break;
                    case "zavrseno": lblZavrseno.Text = "Zavrseno: " + broj; break;
                }
            }
        }

        private string _statusPreIzmene = "";

        private void UcitajKlijente()
        {
            tableKorisnici.DataSource = BazaPodataka.GetSviKlijenti();
            tableKorisnici.Columns["Id"].Visible = false;
            tableKorisnici.Columns["DatumUnosa"].Visible = false;
        }

        private void UcitajPocetnu()
        {
            dataPocetna.DataSource = BazaPodataka.GetNepreuzetiUredjaji();
            dataPocetna.Columns["Id"].Visible = false;
            dataPocetna.Columns["KlijentId"].Visible = false;
        }

        private void UcitajUredjaje()
        {
            tableUredjaji.DataSource = BazaPodataka.GetSviUredjaji();
            tableUredjaji.Columns["Id"].Visible = false;
            tableUredjaji.Columns["KlijentId"].Visible = false;
            tableUredjaji.Columns["KlijentIme"].HeaderText = "Ime Klijenta";

            if (tableUredjaji.Columns["Status"] != null)
            {
                int statusIndex = tableUredjaji.Columns["Status"].DisplayIndex;
                tableUredjaji.Columns.Remove("Status");

                var colStatus = new DataGridViewComboBoxColumn
                {
                    Name = "colStatus",
                    HeaderText = "Status",
                    DataPropertyName = "Status",
                    DisplayIndex = statusIndex,
                    Width = 120
                };
                colStatus.Items.AddRange("primljeno", "u toku", "zavrseno", "preuzeto");

                tableUredjaji.Columns.Add(colStatus);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBar.Width = sideBar.Width == 185 ? 50 : 185;
            btnPocetna.Text = sideBar.Width == 185 ? "Početna" : "";
            btnKlijenti.Text = sideBar.Width == 185 ? "Klijenti" : "";
            btnUredjaji.Text = sideBar.Width == 185 ? "Uređaji" : "";

        }
        private void btnPocetna_Click(object sender, EventArgs e)
        {
            lblNaslov.Text = "E-Servis";
            btnDodajUredjaj.Visible = true;
            tableKorisnici.Visible = false;
            tableUredjaji.Visible = false;
            dataPocetna.Visible = true;
            pocetnaKartice.Visible = true;
            UcitajStatistiku();
            UcitajPocetnu();
            txtPretragaKlijenata.Visible = false;
            txtPretragaUredjaja.Visible = false;
        }
        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            lblNaslov.Text = "Klijenti";
            btnDodajUredjaj.Visible = false;
            tableKorisnici.Visible = true;
            UcitajKlijente();
            tableUredjaji.Visible = false;
            dataPocetna.Visible = false;
            pocetnaKartice.Visible = false;
            txtPretragaKlijenata.Visible = true;
            txtPretragaUredjaja.Visible = false;
        }

        private void btnUredjaji_Click(object sender, EventArgs e)
        {
            lblNaslov.Text = "Uređaji";
            btnDodajUredjaj.Visible = true;
            tableKorisnici.Visible = false;
            tableUredjaji.Visible = true;
            UcitajUredjaje();
            dataPocetna.Visible = false;
            pocetnaKartice.Visible = false;
            txtPretragaKlijenata.Visible = false;
            txtPretragaUredjaja.Visible = true;

        }

        private void btnDodajUredjaj_Click(object sender, EventArgs e)
        {
            FormPrijem frm = new FormPrijem();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BazaPodataka.DodajUredjaj(frm.Uredjaj);
                UcitajUredjaje();
            }
        }

        private void tableKorisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Klijent odabrani = (Klijent)tableKorisnici.Rows[e.RowIndex].DataBoundItem;

            FormPregledKlijenta frm = new FormPregledKlijenta();
            frm.UcitajPodatke(odabrani);
            frm.ShowDialog();
        }

        private void tableUredjaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Uredjaj odabrani = (Uredjaj)tableUredjaji.Rows[e.RowIndex].DataBoundItem;
            if (odabrani == null) return;

            if (e.ColumnIndex == 0)
            {
                FormPrijem frm = new FormPrijem(odabrani);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BazaPodataka.AzurirajUredjaj(frm.Uredjaj);
                    UcitajUredjaje();
                }
            }

            else if (e.ColumnIndex == 1)
            {
                var potvrda = MessageBox.Show(
                    "Da li sigurno želiš da obrišeš uređaj " + odabrani.Model + "?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (potvrda == DialogResult.Yes)
                {
                    BazaPodataka.ObrisiUredjaj(odabrani.Id);
                    UcitajUredjaje();
                }
            }
        }


        private void tableUredjaji_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tableUredjaji.IsCurrentCellDirty)
                tableUredjaji.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void tableUredjaji_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (tableUredjaji.Columns.Count <= e.ColumnIndex) return;
            if (tableUredjaji.Columns[e.ColumnIndex].Name != "colStatus") return;

            Uredjaj odabrani = tableUredjaji.Rows[e.RowIndex].DataBoundItem as Uredjaj;
            if (odabrani == null) return;

            string noviStatus = tableUredjaji.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString();

            if (string.IsNullOrEmpty(noviStatus)) return;
            if (noviStatus == _statusPreIzmene) return;

            if (noviStatus == "zavrseno")
            {
                var frm = new Form
                {
                    Text = "Zavrsi servis",
                    Size = new Size(300, 300),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                var lblNapomena = new Label { Text = "Napomena (opciono):", Location = new Point(20, 20), AutoSize = true };
                var txtNapomena = new TextBox { Location = new Point(20, 45), Width = 240, Height = 40, Multiline = true };
                var lblCena = new Label { Text = "Cena popravke (RSD):", Location = new Point(20, 100), AutoSize = true };
                var txtCena = new TextBox { Location = new Point(20, 125), Width = 240 };

                var btnOk = new Button
                {
                    Text = "Sacuvaj",
                    Location = new Point(80, 175),
                    Width = 100,
                    DialogResult = DialogResult.OK
                };

                frm.Controls.AddRange(new Control[] { lblNapomena, txtNapomena, lblCena, txtCena, btnOk });
                frm.AcceptButton = btnOk;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!decimal.TryParse(txtCena.Text, out decimal cena))
                    {
                        MessageBox.Show("Unesite ispravnu cenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tableUredjaji.Rows[e.RowIndex].Cells["colStatus"].Value = odabrani.Status;
                        return;
                    }
                    BazaPodataka.ZakljuciServis(odabrani.Id, cena, txtNapomena.Text.Trim());
                }
                else
                {
                    tableUredjaji.Rows[e.RowIndex].Cells["colStatus"].Value = odabrani.Status;
                    return;
                }
            }
            else
            {
                var frm = new Form
                {
                    Text = "Promeni status",
                    Size = new Size(300, 180),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                var lblNapomena = new Label { Text = "Napomena (opciono):", Location = new Point(20, 20), AutoSize = true };
                var txtNapomena = new TextBox { Location = new Point(20, 45), Width = 240, Height = 40, Multiline = true };

                var btnOk = new Button
                {
                    Text = "Sacuvaj",
                    Location = new Point(80, 100),
                    Width = 100,
                    DialogResult = DialogResult.OK
                };

                frm.Controls.AddRange(new Control[] { lblNapomena, txtNapomena, btnOk });
                frm.AcceptButton = btnOk;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BazaPodataka.PromeniStatus(odabrani.Id, noviStatus, txtNapomena.Text.Trim());
                }
                else
                {
                    tableUredjaji.Rows[e.RowIndex].Cells["colStatus"].Value = odabrani.Status;
                    return;
                }
            }

            UcitajUredjaje();
        }

        private void tableUredjaji_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (tableUredjaji.Columns[e.ColumnIndex].Name != "colStatus") return;

            _statusPreIzmene = tableUredjaji.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString() ?? "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            btnPocetna.Font = new Font(btnPocetna.Font, FontStyle.Bold);
            btnPocetna.ForeColor = Color.FromArgb(0, 120, 215);
            pictureBox1.BackColor = SystemColors.ControlLight;

        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            btnPocetna.Font = new Font(btnPocetna.Font, FontStyle.Regular);
            btnPocetna.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btnKlijenti_MouseEnter(object sender, EventArgs e)
        {
            btnKlijenti.Font = new Font(btnKlijenti.Font, FontStyle.Bold);
            btnKlijenti.ForeColor = Color.FromArgb(0, 120, 215);
            pictureBox2.BackColor = SystemColors.ControlLight;
        }

        private void btnKlijenti_MouseLeave(object sender, EventArgs e)
        {
            btnKlijenti.Font = new Font(btnKlijenti.Font, FontStyle.Regular);
            btnKlijenti.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void btnUredjaji_MouseEnter(object sender, EventArgs e)
        {
            btnUredjaji.Font = new Font(btnUredjaji.Font, FontStyle.Bold);
            btnUredjaji.ForeColor = Color.FromArgb(0, 120, 215);
            pictureBox3.BackColor = SystemColors.ControlLight;
        }

        private void btnUredjaji_MouseLeave(object sender, EventArgs e)
        {
            btnUredjaji.Font = new Font(btnUredjaji.Font, FontStyle.Regular);
            btnUredjaji.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox3.BackColor = Color.Transparent;
        }

        private void txtPretragaKlijenata_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretragaKlijenata.Text))
                UcitajKlijente();
            else
            {
                tableKorisnici.DataSource = BazaPodataka.PretragaKlijenata(txtPretragaKlijenata.Text.Trim());
                tableKorisnici.Columns["Id"].Visible = false;
                tableKorisnici.Columns["DatumUnosa"].Visible = false;
            }
        }

        private void txtPretragaKlijenata_MouseClick(object sender, MouseEventArgs e)
        {
            txtPretragaKlijenata.Clear();
        }

        private void txtPretragaUredjaja_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretragaUredjaja.Text))
                UcitajUredjaje(); 
            else
                tableUredjaji.DataSource = BazaPodataka.PretraziUredjaje(txtPretragaUredjaja.Text.Trim());
        }

        private void txtPretragaUredjaja_Click(object sender, EventArgs e)
        {
            txtPretragaUredjaja.Clear();
        }
    }
}


