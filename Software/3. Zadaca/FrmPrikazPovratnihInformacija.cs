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
    public partial class FrmPrikazPovratnihInformacija : Form
    {
        public FrmPrikazPovratnihInformacija()
        {
            InitializeComponent();
        }

        private void FrmPrikazPovratnihInformacija_Load(object sender, EventArgs e)
        {
            List<PovratnaInformacija> listaPovratnihInformacija = PovratnaInformacijaRepository.GetSvePovratneInformacije();
            dgvOcjene.DataSource = listaPovratnihInformacija;
            PopraviDgv();
        }

        private void PopraviDgv()
        {
            dgvOcjene.Columns["PovratnaInformacijaID"].Visible = false;
            dgvOcjene.Columns["JeloID"].Visible = false;
            dgvOcjene.Columns["JeloID"].HeaderText = "Jelo";
            dgvOcjene.Columns["OcjenaJela"].HeaderText = "Ocjena jela";
            dgvOcjene.Columns["OcjenaKolicine"].HeaderText = "Ocjena količine";
            dgvOcjene.Columns["Komentar"].HeaderText = "Dodatni komentar/napomene";
            dgvOcjene.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvOcjene.Columns.Add("Naziv jela", "Naziv jela");
            foreach (DataGridViewRow row in dgvOcjene.Rows)
            {
                if (row.Cells["JeloID"].Value != null)
                {
                    int jeloId = (int)row.Cells["JeloID"].Value;
                    string nazivJela = JeloRepository.GetJelo(jeloId).Naziv;
                    row.Cells["Naziv jela"].Value = nazivJela;
                }
            }
            dgvOcjene.Columns["Naziv jela"].DisplayIndex = 0;
        }
    }
}
