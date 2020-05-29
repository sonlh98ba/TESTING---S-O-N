using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTING___S_O_N
{
    public partial class frmAddAccountByIDPassword : Form
    {
        public frmAddAccountByIDPassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtListAccount.Text != "")
            {

                txtListAccount.Clear();
            }
            else
            {
                MessageBox.Show("Not Info Yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            txtListAccount.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtListAccount.Text == "")
            {
                this.Close();
                frmAddingQuestion newform = new frmAddingQuestion();
                newform.Show();
            }
            else
            {
                if (MessageBox.Show("Exit?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    frmAddingQuestion newform = new frmAddingQuestion();
                    newform.Show();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (txtListAccount.Text == "")
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Back to Home?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtListAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
