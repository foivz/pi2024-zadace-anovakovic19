using _3.Zadaca.models;
using _3.Zadaca.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Zadaca
{
    public partial class FrmUnosJela : Form
    {
        public FrmUnosJela()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivJela.Text;
            string opis = txtOpisJela.Text;
            string kategorija = cbKategorija.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Naziv jela je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(opis))
            {
                MessageBox.Show("Opis jela je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(kategorija))
            {
                MessageBox.Show("Kategorija jela je obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JeloRepository.InsertJelo(naziv, opis, kategorija);
            MessageBox.Show("Uspješno ste unijeli jelo u sustav!", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OcistiPolja();
        }

        private void FrmUnosJela_Load(object sender, EventArgs e)
        {
            IspuniKategorije();
        }

        private void IspuniKategorije()
        {
            List<string> listakategorija = new List<string>();
            listakategorija.Add("juha");
            listakategorija.Add("glavno jelo");
            listakategorija.Add("prilog");
            listakategorija.Add("desert");
            cbKategorija.DataSource = listakategorija;
            cbKategorija.SelectedIndex = -1;
        }

        private void OcistiPolja()
        {
            txtNazivJela.Text = "";
            txtOpisJela.Text = "";
            cbKategorija.SelectedIndex = -1;
        }
    }
}
