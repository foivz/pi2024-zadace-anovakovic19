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
    public partial class FrmJela : Form
    {
        public int odabranoJelo;

        public FrmJela()
        {
            InitializeComponent();
        }

        private void FrmJela_Load(object sender, EventArgs e)
        {
            PrikaziJela();
        }

        private void PrikaziJela(string naziv = "")
        {
            List<Jelo> jela = JeloRepository.GetSvaJelaPoNazivu(naziv);
            dgvJela.DataSource = jela;
            dgvJela.Columns["jelo_id"].Visible = false;
        }

        private void txtPretraziJela_KeyUp(object sender, KeyEventArgs e)
        {
            string jelo = txtPretraziJela.Text;
            PrikaziJela(jelo);
        }

        private void dgvJela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow odabraniRed = dgvJela.Rows[e.RowIndex];
            odabranoJelo = Convert.ToInt32(odabraniRed.Cells["jelo_id"].Value.ToString());
            btnObrisiJelo.Enabled = true;
        }

        private void btnObrisiJelo_Click(object sender, EventArgs e)
        {
            if(odabranoJelo > 0)
            {
                JeloRepository.DeleteJelo(odabranoJelo);
                PrikaziJela("");
                btnObrisiJelo.Enabled = false;
            }
        }
    }
}
