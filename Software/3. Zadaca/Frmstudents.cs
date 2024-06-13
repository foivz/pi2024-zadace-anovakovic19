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
    public partial class Frmstudents : Form
    {
        public Frmstudents()
        {
            InitializeComponent();
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            FrmMeni frmMeni = new FrmMeni();
            frmMeni.Show();
        }

        private void btnPrikazKomentara_Click(object sender, EventArgs e)
        {
            FrmPrikazPovratnihInformacija frmPrikazPovratnihInformacija = new FrmPrikazPovratnihInformacija();
            frmPrikazPovratnihInformacija.ShowDialog();
        }
    }
}
