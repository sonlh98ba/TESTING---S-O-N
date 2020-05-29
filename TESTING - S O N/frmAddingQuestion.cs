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
    public partial class frmAddingQuestion : Form
    {
        public frmAddingQuestion()
        {
            InitializeComponent();
            this.ActiveControl = this.btnHome;
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            frmAddAccountByFullInfo newform = new frmAddAccountByFullInfo();
            newform.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIDPassword_Click(object sender, EventArgs e)
        {
            frmAddAccountByIDPassword newform = new frmAddAccountByIDPassword();
            newform.Show();
            this.Close();
        }
    }
}
