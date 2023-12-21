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
    public partial class ucGown : UserControl
    {
        public EventHandler onSelect = null;
        public ucGown()
        {
            InitializeComponent();
        }

        //properties of usercontrol
        public int id { get; set; }
        public string gName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string gPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public Image gImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }

        private void txtPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // open detail form design latter
            frmDetails details = new frmDetails() { id = id };
            details.ShowDialog();
        }

        private void ucGown_MouseEnter(object sender, EventArgs e)
        {
            // change color on hover
            this.BackColor = Color.LightCyan;
        }

        private void ucGown_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
