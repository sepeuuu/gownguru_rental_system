
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
        private bool gownCollapsed;
        private bool settingsCollapsed;
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
   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAdminDashboard());
        }

        private void btnGown_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother
            GownTimer.Start();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
        }

        private void btnRented_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRented());
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReturned());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SettingsTimer.Start();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategory());
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGown());
        }

        private void btnManage_TextChanged(object sender, EventArgs e)
        {
            openChildForm(new frmGown());
        }

        private void btnSettings_TextChanged(object sender, EventArgs e)
        {
            SettingsTimer.Start();
        }

        private void btnFormerEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFormerEmployee());
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            openChildForm(new frmArchive());
        }

        private void btnTransacLog_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTransactionLog());
        }

        private void GownTimer_Tick(object sender, EventArgs e)
        {
            if (gownCollapsed)
            {
                GownContainer.Height += 10;
                if (GownContainer.Height == GownContainer.MaximumSize.Height)
                {
                    gownCollapsed = false;
                    GownTimer.Stop();
                }
            }
            else
            {
                GownContainer.Height -= 10;
                if (GownContainer.Height == GownContainer.MinimumSize.Height)
                {
                    gownCollapsed = true;
                    GownTimer.Stop();
                }
            }
        }

        private void SettingsTimer_Tick(object sender, EventArgs e)
        {
            if (settingsCollapsed)
            {
                SettingsContainer.Height += 10;
                if (SettingsContainer.Height == SettingsContainer.MaximumSize.Height)
                {
                    settingsCollapsed = false;
                    SettingsTimer.Stop();
                }
            }
            else
            {
                SettingsContainer.Height -= 10;
                if (SettingsContainer.Height == SettingsContainer.MinimumSize.Height)
                {
                    settingsCollapsed = true;
                    SettingsTimer.Stop();
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPOS());
        }

        private void SettingsContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
