using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmDetails()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void frmDetails_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cm = new SqlCommand("SELECT * FROM tblGown WHERE CONCAT(gid,gname,gdescription,gsize,gcolor,gcondition,gprice,gdateadded,gcategory,gstatus,gpic)", con);
                txtName.Text = dr["gName"].ToString();
                txtPrice.Text = dr["gName"].ToString();
                txtStatus.Text = dr["gName"].ToString();
                txtColor.Text = dr["gName"].ToString();
                txtCategory.Text = dr["gName"].ToString();
                txtCondition.Text = dr["gName"].ToString();
                txtDescription.Text = dr["gName"].ToString();

                Byte[] ImageArray = (byte[])(dr["gpic"]);
                byte[] ImageByteArray = ImageArray;
                txtPic.Image = Image.FromStream(new MemoryStream(ImageArray));
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
