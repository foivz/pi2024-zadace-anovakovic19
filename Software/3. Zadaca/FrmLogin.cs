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
        string Username = "nastavnik";
        string Password = "test";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("The Username field is empty!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("The password field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
            else
            {
                if (txtUsername.Text == Username && txtPassword.Text == Password)
                {
                    Frmstudents frmstudents = new Frmstudents();
                    Hide();
                    frmstudents.ShowDialog();
                    Close();

                } else
                {
                    MessageBox.Show("Wrong login!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
    }
}
