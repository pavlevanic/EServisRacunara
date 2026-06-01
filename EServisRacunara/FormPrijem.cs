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
    public partial class FormPrijem : Form
    {
        public Uredjaj Uredjaj { get; private set; }

        private Klijent _pronadjeniKlijent = null;
        private bool _izmena = false;

        public FormPrijem()
        {
            this.Size = new Size(1071, 648);
            InitializeComponent();
            lblPrijem.Text = "Novi prijem uređaja";
            this.Text = "Novi prijem uređaja";
            datePrijem.Value = DateTime.Today;
        }

        public FormPrijem(Uredjaj u) : this()
        {
            lblPrijem.Text = "Izmena uređaja";
            _izmena = true;
            this.Text = "Izmena uređaja";
            Uredjaj = u;
            PopuniPolja(u);
        }

        private void PopuniPolja(Uredjaj u)
        {
            var klijenti = BazaPodataka.GetSviKlijenti();
            _pronadjeniKlijent = klijenti.Find(k => k.Id == u.KlijentId);

            if (_pronadjeniKlijent != null)
            {
                txtTelefon.Text = _pronadjeniKlijent.Telefon;
                txtIme.Text = _pronadjeniKlijent.Ime;
                txtPrezime.Text = _pronadjeniKlijent.Prezime;
                txtAdresa.Text = _pronadjeniKlijent.Adresa;

                ZakljucajPolja(true);
            }

            txtTip.Text = u.TipUredjaja;
            txtModel.Text = u.Model;
            txtKvar.Text = u.OpisKvara;
            datePrijem.Value = u.DatumPrijema;
            txtNapomena.Text = u.Napomena;
        }

        private void btnPronadjiKlijenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Unesite broj telefona.", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var klijenti = BazaPodataka.PretragaKlijenata(txtTelefon.Text.Trim());

            if (klijenti.Count > 0)
            {
                _pronadjeniKlijent = klijenti[0];
                txtIme.Text = _pronadjeniKlijent.Ime;
                txtPrezime.Text = _pronadjeniKlijent.Prezime;
                txtAdresa.Text = _pronadjeniKlijent.Adresa;

                ZakljucajPolja(true);

                MessageBox.Show("Klijent pronađen: " + _pronadjeniKlijent.Ime + " " + _pronadjeniKlijent.Prezime,
                    "Pronađen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _pronadjeniKlijent = null;
                ZakljucajPolja(false);

                txtIme.Text = "";
                txtPrezime.Text = "";
                txtAdresa.Text = "";

                MessageBox.Show("Klijent nije pronađen. Unesite podatke.", "Novi klijent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ZakljucajPolja(bool zakljucaj)
        {
            txtIme.ReadOnly = zakljucaj;
            txtPrezime.ReadOnly = zakljucaj;
            txtAdresa.ReadOnly = zakljucaj;

            Color boja = zakljucaj ? Color.LightGray : Color.White;
            txtIme.BackColor = boja;
            txtPrezime.BackColor = boja;
            txtAdresa.BackColor = boja;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Svi podaci o klijentu su obavezni.", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTip.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtKvar.Text))
            {
                MessageBox.Show("Tip, model i opis kvara su obavezni.", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int klijentId;

            if (_pronadjeniKlijent != null)
            {
                klijentId = _pronadjeniKlijent.Id;
            }
            else
            {
                var noviKlijent = new Klijent
                {
                    Ime = txtIme.Text.Trim(),
                    Prezime = txtPrezime.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adresa = txtAdresa.Text.Trim()
                };
                klijentId = BazaPodataka.DodajKlijenta(noviKlijent);
            }

            Uredjaj = new Uredjaj
            {
                Id = _izmena ? Uredjaj.Id : 0,
                KlijentId = klijentId,
                TipUredjaja = txtTip.Text.Trim(),
                Model = txtModel.Text.Trim(),
                OpisKvara = txtKvar.Text.Trim(),
                DatumPrijema = datePrijem.Value.Date,
                Status = _izmena ? Uredjaj.Status : "primljeno",
                CenaPopravke = _izmena ? Uredjaj.CenaPopravke : 0,
                Napomena = txtNapomena.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
