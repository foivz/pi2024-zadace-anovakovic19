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
        public FrmJela()
        {
            InitializeComponent();
        }

        private void FrmJela_Load(object sender, EventArgs e)
        {
            PrikaziJela();
        }

        private void PrikaziJela()
        {
            List<Jelo> jela = JeloRepository.GetSvaJela();
            dgvJela.DataSource = jela;
        }
    }
}
