using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3.Zadaca
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("The Username field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "")
            {
                MessageBox.Show("The password field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("The password must be at least 4 characters long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // Provjera da li korisničko ime završava sa "@foi.hr"
                if (txtUsername.Text.EndsWith("@foi.hr"))
                {
                    Frmstudents frmstudents = new Frmstudents();
                    Hide();
                    frmstudents.ShowDialog();
                    Close();
                } else
                {
                    MessageBox.Show("Wrong login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}