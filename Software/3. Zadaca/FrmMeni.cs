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
    public partial class FrmMeni : Form
    {
        public FrmMeni()
        {
            InitializeComponent();
        }

        private void btnPrikaziJela_Click(object sender, EventArgs e)
        {
            FrmJela frmJela = new FrmJela();
            frmJela.ShowDialog();
        }

        private void btnUnesiJela_Click(object sender, EventArgs e)
        {
            FrmUnosJela frmUnosJela = new FrmUnosJela();
            frmUnosJela.ShowDialog();
        }
    }
}
