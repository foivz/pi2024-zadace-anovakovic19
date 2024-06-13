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
    }
}
