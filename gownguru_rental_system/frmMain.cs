
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //toshow subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(childForm);
            CenterPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //_obj = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAdminDashboard());
        }

        private void btnGown_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGown());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnRented_Click(object sender, EventArgs e)
        {

        }

        private void btnReturned_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategory());
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmSettings());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategory());
        }
    }
}
