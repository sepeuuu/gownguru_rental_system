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
    public partial class frmRented : Form
    {
        public frmRented()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrder formModule = new frmOrder();
            //formModule.btnSave.Enabled = true;
            //formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            //LoadGown();
        }
    }
}
