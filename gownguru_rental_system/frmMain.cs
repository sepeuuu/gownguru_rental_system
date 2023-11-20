
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
            //customizeDesign();
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

        /*private void customizeDesign()
        {
            panelGownSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelGownSubMenu.Visible == true)
                panelGownSubMenu.Visible = false;
            if (panelSettingsSubMenu.Visible == true)
                panelSettingsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }*/

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
            //showSubMenu(panelGownSubMenu);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmCustomer());
            //hideSubMenu();
        }

        private void btnRented_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRented());
            //hideSubMenu();
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmReturned());
            //hideSubMenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());
           // hideSubMenu();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSettingsSubMenu);
            SettingsTimer.Start();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategory());
            //hideSubMenu();
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
           // hideSubMenu();
        }

        private void btnManage_TextChanged(object sender, EventArgs e)
        {
            openChildForm(new frmGown());
            //hideSubMenu();
        }

        private void btnSettings_TextChanged(object sender, EventArgs e)
        {
            // showSubMenu(panelGownSubMenu);
            SettingsTimer.Start();
        }

        private void btnFormerEmp_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmFormerEmployee());
            //hideSubMenu();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmArchive());
            //hideSubMenu();
        }

        private void btnTransacLog_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmTransacLog());
           // hideSubMenu();
        }

        private void panelGownSubMenu_Paint(object sender, PaintEventArgs e)
        {

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

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
