using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EServisRacunara
{
    public partial class FormPregledKlijenta : Form
    {
        private List<Uredjaj> _uredjaji;
        private Uredjaj _odabraniUredjaj;

        public FormPregledKlijenta()
        {
            InitializeComponent();
        }

        public void UcitajPodatke(Klijent klijent)
        {
            lblImeKlijenta.Text = klijent.Ime + " " + klijent.Prezime;
            lblTelefonKlijenta.Text = klijent.Telefon;
            lblAdresaKlijenta.Text = klijent.Adresa;

            _uredjaji = BazaPodataka.GetUredjajiKlijenta(klijent.Id);

            listUredjaji.Items.Clear();

            if (_uredjaji.Count == 0)
            {
                listUredjaji.Items.Add("Nema uređaja");
                OcistiDetalje();
                return;
            }

            foreach (var u in _uredjaji)
                listUredjaji.Items.Add(u.Model + " — " + u.Status);

            listUredjaji.SelectedIndex = 0;
        }

        private void listUredjaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listUredjaji.SelectedIndex;
            if (i < 0 || i >= _uredjaji.Count) return;

            _odabraniUredjaj = _uredjaji[i];
            PrikaziDetalje(_odabraniUredjaj);
        }

        private void PrikaziDetalje(Uredjaj u)
        {
            lblNazivUredjaj.Text = "Uređaj:";      
            lblDetaljUredjaj.Text = u.TipUredjaja + " — " + u.Model;
            lblNazivKvar.Text = "Kvar:";
            lblDetaljKvar.Text =   u.OpisKvara;
            lblDetaljStatus.Text =  u.Status;
            lblDetaljCena.Text = u.CenaPopravke + " RSD";
            lblDetaljDatum.Text = u.DatumPrijema.ToString("dd.MM.yyyy");
            lblDetaljNapomena.Text =string.IsNullOrWhiteSpace(u.Napomena) ? "Nema napomene" : u.Napomena;

            btnPreuzeto.Enabled = u.Status != "preuzeto";
            btnPromeniStatus.Enabled = u.Status != "preuzeto";
        }

        private void OcistiDetalje()
        {
            lblDetaljUredjaj.Text = "";
            lblDetaljKvar.Text = "";
            lblDetaljStatus.Text = "";
            lblDetaljCena.Text = "";
            lblDetaljDatum.Text = "";
            lblDetaljNapomena.Text = "";
            btnPreuzeto.Enabled = false;
            btnPromeniStatus.Enabled = false;
        }


        private void btnPromeniStatus_Click_1(object sender, EventArgs e)
        {
            if (_odabraniUredjaj == null) return;

            var frm = new Form
            {
                Text = "Promeni status",
                Size = new Size(300, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var lblStatus = new Label { Text = "Status:", Location = new Point(20, 20), AutoSize = true };
            var cmb = new ComboBox
            {
                Location = new Point(20, 40),
                Width = 240,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmb.Items.AddRange(new object[] { "primljeno", "u toku", "zavrseno", "preuzeto" });
            cmb.SelectedItem = _odabraniUredjaj.Status;

            var lblCena = new Label { Text = "Cena popravke (RSD):", Location = new Point(20, 90), AutoSize = true, Visible = false };
            var txtCena = new TextBox { Location = new Point(20, 110), Width = 240, Visible = false };

            cmb.SelectedIndexChanged += (s, ev) =>
            {
                bool zavrseno = cmb.SelectedItem?.ToString() == "zavrseno";
                lblCena.Visible = zavrseno;
                txtCena.Visible = zavrseno;
            };

            var lblNapomena = new Label { Text = "Napomena (opciono):", Location = new Point(20, 135), AutoSize = true };
            var txtNapomena = new TextBox { Location = new Point(20, 155), Width = 240, Height = 40, Multiline = true };

            var btnOk = new Button
            {
                Text = "Sacuvaj",
                Location = new Point(80, 205),
                Width = 100,
                DialogResult = DialogResult.OK
            };

            frm.Size = new Size(300, 285);
            frm.Controls.AddRange(new Control[] { lblStatus, cmb, lblCena, txtCena, lblNapomena, txtNapomena, btnOk });
            frm.AcceptButton = btnOk;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (cmb.SelectedItem == null) return;

                string noviStatus = cmb.SelectedItem.ToString();

                if (noviStatus == "zavrseno")
                {
                    if (!decimal.TryParse(txtCena.Text, out decimal cena))
                    {
                        MessageBox.Show("Unesite ispravnu cenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    BazaPodataka.ZakljuciServis(_odabraniUredjaj.Id, cena, txtNapomena.Text.Trim());
                }
                else
                {
                    BazaPodataka.PromeniStatus(_odabraniUredjaj.Id, noviStatus, txtNapomena.Text.Trim());
                }

                _odabraniUredjaj.Status = noviStatus;
                PrikaziDetalje(_odabraniUredjaj);

                int idx = listUredjaji.SelectedIndex;
                listUredjaji.Items[idx] = _odabraniUredjaj.Model + " — " + noviStatus;
            }
        }

        private void btnPreuzeto_Click_1(object sender, EventArgs e)
        {
            if (_odabraniUredjaj == null) return;

            var potvrda = MessageBox.Show(
                "Da li je klijent preuzeo uredjaj " + _odabraniUredjaj.Model + "?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
            {
                BazaPodataka.PromeniStatus(_odabraniUredjaj.Id, "preuzeto", "Klijent preuzeo uredjaj.");

                _odabraniUredjaj.Status = "preuzeto";
                PrikaziDetalje(_odabraniUredjaj);

                int idx = listUredjaji.SelectedIndex;
                listUredjaji.Items[idx] = _odabraniUredjaj.Model + " — preuzeto";
            }
        }

       
    }
}
