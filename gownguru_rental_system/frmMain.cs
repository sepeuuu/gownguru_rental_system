
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
    public partial class frmMain : Sample
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static frmMain _obj;

        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddControls(Form F)
        {
            CenterPanel.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new frmAdminDashboard());
        }

        private void btnGown_Click(object sender, EventArgs e)
        {
            AddControls(new frmGown());
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategory());
        }
    }
}
