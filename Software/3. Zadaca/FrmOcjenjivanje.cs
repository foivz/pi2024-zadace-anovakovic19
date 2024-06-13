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
    public partial class FrmOcjenjivanje : Form
    {
        public int odabranoJelo;
        public string odabranogJeloNaziv;
        public FrmOcjenjivanje(int IdOdabranogJela, string NazivJela)
        {
            InitializeComponent();
            odabranoJelo = IdOdabranogJela;
            odabranogJeloNaziv = NazivJela;

        }

        private void FrmOcjenjivanje_Load(object sender, EventArgs e)
        {
            lblNazivJela.Text = odabranogJeloNaziv;
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            int jeloId = odabranoJelo;
            int ocjenaJela = (int)nudOcjenaJela.Value;
            int ocjenaKolicineJela = (int)nudOcjenaKolicineJela.Value;
            string komentar = rtKomentar.Text;

            PovratnaInformacijaRepository.InsertPovratnaInformacija(jeloId, ocjenaJela, ocjenaKolicineJela, komentar);
            MessageBox.Show("Uspješno ste ocijenili jelo", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
